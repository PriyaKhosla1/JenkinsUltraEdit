﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace UltraEditAutomation
{
    public partial class VerifyBlockComment_Removed
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording-specific initialization code goes here.
        }

        public void VerifyRemoveBlockComment(RepoItemInfo argument1)
        {
            // XPath for the editor element
          var element59648 = repo.UltraEdit64Bit.editorScreen;

            int startLine = 10; // Start line to check
            int endLine = 15; // End line to check

            try
            {
                // Locate the editor element
                var editor = Host.Local.FindSingle<Unknown>(repo.UltraEdit64Bit.editorScreen.GetPath());

                if (editor == null)
                {
                    Report.Error("Editor element not found. Check the XPath or if the element is visible at runtime.");
                    return;
                }

                // Retrieve the text content from the editor
                string editorText = editor.Element.GetAttributeValueText("WindowText") ?? editor.Element.GetAttributeValueText("AccessibleName");
                if (string.IsNullOrEmpty(editorText))
                {
                    Report.Warn("Unable to retrieve text from the editor using 'WindowText' or 'AccessibleName'.");
                    return;
                }

                // Split the text into lines
                string[] lines = editorText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                if (lines.Length < endLine)
                {
                    Report.Warn("The editor does not contain enough lines to check from the specified range.");
                    return;
                }

                editor.Focus();

                // Check if the block from line 10 to line 15 is not commented
                bool allUncommented = true;
                for (int i = startLine - 1; i < endLine; i++)  // Adjust for 0-based index
                {
                    string line = lines[i].Trim();

                    // Check if the line does not start with comment markers
                    if (line.StartsWith("//") || line.StartsWith("/*") || line.StartsWith("#") || line.EndsWith("*/"))
                    {
                        // Line is commented, report failure
                        Report.Failure($"The line at line {i + 1} ('{line}') is commented.");
                        allUncommented = false;
                    }
                }

                if (allUncommented)
                {
                    Report.Success($"The block from line {startLine} to line {endLine} is NOT fully commented.");
                }
                else
                {
                    // If any line is commented, report error and throw an exception
                    Report.Error($"The block from line {startLine} to line {endLine} is commented. The test will fail.");
                    throw new RanorexException("The block is commented, test case failed.");
                }
            }
            catch (RanorexException ex)
            {
                Report.Error("Ranorex-specific error: " + ex.Message);
                throw; // Re-throw the exception to indicate failure
            }
            catch (Exception ex)
            {
                Report.Error("An unexpected error occurred: " + ex.Message);
                throw; // Re-throw the exception to indicate failure
            }
        }
    }
}
