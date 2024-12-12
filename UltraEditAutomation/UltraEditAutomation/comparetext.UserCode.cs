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
    public partial class comparetext
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
         private string copiedText1; // Class-level variable
        private string copiedText2; // Class-level variable
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Content1()
        {
            try
   			 {
       		 copiedText1 = System.Windows.Forms.Clipboard.GetText();
       		 Report.Info($"Captured Content1: {copiedText1}");
  			  }
   		    catch (Exception ex)
   		     {
       		 Report.Error($"Failed to capture Content1: {ex.Message}");
   			 }
        }

        public void Content2()
        {
        	try
   			 {
       		 copiedText2 = System.Windows.Forms.Clipboard.GetText();
       		 Report.Info($"Captured Content2: {copiedText2}");
  			  }
   		    catch (Exception ex)
   		     {
       		 Report.Error($"Failed to capture Content1: {ex.Message}");
   			 }
            
        }

        public void CompareContent()
        {
            try
            {
            	if (string.IsNullOrEmpty(copiedText1) || string.IsNullOrEmpty(copiedText2))
            	{
            		Report.Error("One or both clipboard contents are empty. Ensure CaptureContent1 and CaptureContent2 are executed.");
            		Validate.Fail("Missing clipboard content.");
            		return;
            	}
            	
            	if (copiedText1==copiedText2)
            	{
            		Report.Success("CopiedText1 and CopiedText2 are identical.");
            	}
            	 else
                {
                    Report.Error("CopiedText1 and CopiedText2 do not match.");
                    Report.Info($"CopiedText1: {copiedText1}");
                    Report.Info($"CopiedText2: {copiedText2}");
                    Validate.Fail("Clipboard contents do not match.");
                }
            }
            catch (Exception ex)
            {
                Report.Error($"An error occurred during comparison: {ex.Message}");
                Validate.Fail("Comparison failed due to an exception.");
            }
        }
        
        

    }
}
