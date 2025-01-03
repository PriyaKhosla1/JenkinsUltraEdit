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
    ///The Case2_NonIBM500Conversion recording.
    /// </summary>
    [TestModule("b596690a-84cb-4914-80f2-48ed9792ec5a", ModuleType.Recording, 1)]
    public partial class Case2_NonIBM500Conversion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static Case2_NonIBM500Conversion instance = new Case2_NonIBM500Conversion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Case2_NonIBM500Conversion()
        {
            File = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Case2_NonIBM500Conversion Instance
        {
            get { return instance; }
        }

#region Variables

        string _File;

        /// <summary>
        /// Gets or sets the value of variable File.
        /// </summary>
        [TestVariable("f8fdd83e-2175-47b7-9e7b-32877985b5c7")]
        public string File
        {
            get { return _File; }
            set { _File = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Advanced'.", repo.UltraEdit64Bit.AdvancedInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.Advanced.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.Settings' at 8;51.", repo.UltraEdit64Bit.SettingsInfo, new RecordItemIndex(1));
            repo.UltraEdit64Bit.Settings.Click("8;51");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.FileHandling' at 59;3.", repo.Configuration.FileHandlingInfo, new RecordItemIndex(2));
            repo.Configuration.FileHandling.Click("59;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.Conversions' at 41;9.", repo.Configuration.ConversionsInfo, new RecordItemIndex(3));
            repo.Configuration.Conversions.Click("41;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.UseIBM500StandardForEBCDICConversi' at 10;12.", repo.Configuration.UseIBM500StandardForEBCDICConversiInfo, new RecordItemIndex(4));
            repo.Configuration.UseIBM500StandardForEBCDICConversi.Click("10;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'Configuration.UseIBM500StandardForEBCDICConversi'.", repo.Configuration.UseIBM500StandardForEBCDICConversiInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Configuration.UseIBM500StandardForEBCDICConversiInfo, "Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Close() on item 'Configuration'.", repo.Configuration.SelfInfo, new RecordItemIndex(6));
            repo.Configuration.Self.Close();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.Advanced'.", repo.UltraEdit64Bit.AdvancedInfo, new RecordItemIndex(7));
            repo.UltraEdit64Bit.Advanced.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.Conversions' at 90;9.", repo.FormCUltraEditFilesUe20241025T06120.ConversionsInfo, new RecordItemIndex(8));
            repo.FormCUltraEditFilesUe20241025T06120.Conversions.Click("90;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ASCIIToEBCDIC' at 83;12.", repo.Uedit64.ASCIIToEBCDICInfo, new RecordItemIndex(9));
            repo.Uedit64.ASCIIToEBCDIC.Click("83;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ApplicationMenu' at 29;12.", repo.Uedit64.ApplicationMenuInfo, new RecordItemIndex(10));
            repo.Uedit64.ApplicationMenu.Click("29;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.SaveAs' at Center.", repo.Uedit64.SaveAsInfo, new RecordItemIndex(11));
            repo.Uedit64.SaveAs.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$File' with focus on 'SaveAs.Text1001'.", repo.SaveAs.Text1001Info, new RecordItemIndex(12));
            repo.SaveAs.Text1001.PressKeys(File);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveAs.ButtonSave' at 22;17.", repo.SaveAs.ButtonSaveInfo, new RecordItemIndex(13));
            repo.SaveAs.ButtonSave.Click("22;17");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
