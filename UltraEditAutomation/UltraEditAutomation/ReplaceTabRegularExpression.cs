﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace UltraEditAutomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ReplaceTabRegularExpression recording.
    /// </summary>
    [TestModule("103f669d-51d0-4654-989f-5c5de6474b6e", ModuleType.Recording, 1)]
    public partial class ReplaceTabRegularExpression : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static ReplaceTabRegularExpression instance = new ReplaceTabRegularExpression();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReplaceTabRegularExpression()
        {
            Text = "test";
            AddedExpression = "";
            AddedExpression2 = "";
            GetText = "";
            ReplaceAddedExpression = "";
            ReplaceAddedExpression2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReplaceTabRegularExpression Instance
        {
            get { return instance; }
        }

#region Variables

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("dcfd1935-328a-412b-8516-d1d5b02aeddc")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        string _AddedExpression;

        /// <summary>
        /// Gets or sets the value of variable AddedExpression.
        /// </summary>
        [TestVariable("5061169f-9880-4311-a1d4-d259bb766b67")]
        public string AddedExpression
        {
            get { return _AddedExpression; }
            set { _AddedExpression = value; }
        }

        string _AddedExpression2;

        /// <summary>
        /// Gets or sets the value of variable AddedExpression2.
        /// </summary>
        [TestVariable("35699bff-4b61-4ff3-827f-b6a9b9e6ff71")]
        public string AddedExpression2
        {
            get { return _AddedExpression2; }
            set { _AddedExpression2 = value; }
        }

        string _GetText;

        /// <summary>
        /// Gets or sets the value of variable GetText.
        /// </summary>
        [TestVariable("1752fce0-5f69-4982-aeea-9bb5506024f0")]
        public string GetText
        {
            get { return _GetText; }
            set { _GetText = value; }
        }

        string _ReplaceAddedExpression;

        /// <summary>
        /// Gets or sets the value of variable ReplaceAddedExpression.
        /// </summary>
        [TestVariable("83479836-1f8d-4dfb-9bb8-9a7a5f2dcb77")]
        public string ReplaceAddedExpression
        {
            get { return _ReplaceAddedExpression; }
            set { _ReplaceAddedExpression = value; }
        }

        string _ReplaceAddedExpression2;

        /// <summary>
        /// Gets or sets the value of variable ReplaceAddedExpression2.
        /// </summary>
        [TestVariable("ce091b9b-684c-4f5d-a891-a4467b902a01")]
        public string ReplaceAddedExpression2
        {
            get { return _ReplaceAddedExpression2; }
            set { _ReplaceAddedExpression2 = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Replace' at 34;4.", repo.HEXFindReplace.ReplaceInfo, new RecordItemIndex(0));
            repo.HEXFindReplace.Replace.Click("34;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Selected='True') on item 'HEXFindReplace.Replace'.", repo.HEXFindReplace.ReplaceInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.HEXFindReplace.ReplaceInfo, "Selected", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Text1687' at 47;16.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(2));
            repo.HEXFindReplace.Text1687.Click("47;16");
            Delay.Milliseconds(0);
            
            // Find What Textfield
            Report.Log(ReportLevel.Info, "Section", "Find What Textfield", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(4));
            repo.HEXFindReplace.Text1687.PressKeys(Text);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'HEXFindReplace.Text1687' and assigning its value to variable 'GetText'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(5));
            GetText = repo.HEXFindReplace.Text1687.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Button2' at 9;16.", repo.HEXFindReplace.Button2Info, new RecordItemIndex(6));
            repo.HEXFindReplace.Button2.Click("9;16");
            Delay.Milliseconds(0);
            
            AddedExpression = GetSymbol(repo.Uedit64.MenuItemPlusOneOrMorePrecedingChar, GetText);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.MenuItemPlusOneOrMorePrecedingChar' at 80;17.", repo.Uedit64.MenuItemPlusOneOrMorePrecedingCharInfo, new RecordItemIndex(8));
            repo.Uedit64.MenuItemPlusOneOrMorePrecedingChar.Click("80;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AddedExpression) on item 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.HEXFindReplace.Text1687Info, "Text", AddedExpression);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(10));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Button2' at 9;16.", repo.HEXFindReplace.Button2Info, new RecordItemIndex(11));
            repo.HEXFindReplace.Button2.Click("9;16");
            Delay.Milliseconds(0);
            
            AddedExpression2 = GetSymbol(repo.Uedit64.MenuItemPercentStartOfLine, AddedExpression);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.MenuItemPercentStartOfLine' at 78;5.", repo.Uedit64.MenuItemPercentStartOfLineInfo, new RecordItemIndex(13));
            repo.Uedit64.MenuItemPercentStartOfLine.Click("78;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AddedExpression2) on item 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.HEXFindReplace.Text1687Info, "Text", AddedExpression2);
            Delay.Milliseconds(0);
            
            // Replace With  Textfield
            Report.Log(ReportLevel.Info, "Section", "Replace With  Textfield", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Text1695' at 218;15.", repo.HEXFindReplace.Text1695Info, new RecordItemIndex(16));
            repo.HEXFindReplace.Text1695.Click("218;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'HEXFindReplace.Text1695'.", repo.HEXFindReplace.Text1695Info, new RecordItemIndex(17));
            repo.HEXFindReplace.Text1695.PressKeys(Text);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'HEXFindReplace.Text1695' and assigning its value to variable 'GetText'.", repo.HEXFindReplace.Text1695Info, new RecordItemIndex(18));
            GetText = repo.HEXFindReplace.Text1695.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Button3' at 4;14.", repo.HEXFindReplace.Button3Info, new RecordItemIndex(19));
            repo.HEXFindReplace.Button3.Click("4;14");
            Delay.Milliseconds(0);
            
            //GetSymbolOfCarriageReturn(repo.Uedit64.MenuItemCaretrCarriageReturnCROnly, GetText);
            //Delay.Milliseconds(0);
            
            ReplaceAddedExpression = GetSymbol(repo.Uedit64.MenuItemCaretrCarriageReturnCROnly, GetText);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.MenuItemCaretrCarriageReturnCROnly' at 63;18.", repo.Uedit64.MenuItemCaretrCarriageReturnCROnlyInfo, new RecordItemIndex(22));
            repo.Uedit64.MenuItemCaretrCarriageReturnCROnly.Click("63;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ReplaceAddedExpression) on item 'HEXFindReplace.Text1695'.", repo.HEXFindReplace.Text1695Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.HEXFindReplace.Text1695Info, "Text", ReplaceAddedExpression);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(24));
            Delay.Duration(100, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Button3' at 13;11.", repo.HEXFindReplace.Button3Info, new RecordItemIndex(25));
            repo.HEXFindReplace.Button3.Click("13;11");
            Delay.Milliseconds(0);
            
            //GetSymbolOfLineFeed(repo.Uedit64.MenuItemCaretnLineFeedLFOnlyUnix, ReplaceAddedExpression);
            //Delay.Milliseconds(0);
            
            ReplaceAddedExpression2 = GetSymbol(repo.Uedit64.MenuItemCaretnLineFeedLFOnlyUnix, ReplaceAddedExpression);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.MenuItemCaretnLineFeedLFOnlyUnix' at 43;4.", repo.Uedit64.MenuItemCaretnLineFeedLFOnlyUnixInfo, new RecordItemIndex(28));
            repo.Uedit64.MenuItemCaretnLineFeedLFOnlyUnix.Click("43;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ReplaceAddedExpression2) on item 'HEXFindReplace.Text1695'.", repo.HEXFindReplace.Text1695Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.HEXFindReplace.Text1695Info, "Text", ReplaceAddedExpression2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Close() on item 'HEXFindReplace'.", repo.HEXFindReplace.SelfInfo, new RecordItemIndex(30));
            repo.HEXFindReplace.Self.Close();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
