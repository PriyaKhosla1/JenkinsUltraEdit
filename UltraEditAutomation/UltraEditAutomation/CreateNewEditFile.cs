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
    ///The CreateNewEditFile recording.
    /// </summary>
    [TestModule("bc39ae22-0ade-45b7-bc49-09de583621a8", ModuleType.Recording, 1)]
    public partial class CreateNewEditFile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static CreateNewEditFile instance = new CreateNewEditFile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewEditFile()
        {
            Text = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewEditFile Instance
        {
            get { return instance; }
        }

#region Variables

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("ed82472e-8886-44fb-9fbb-d51b539ce817")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ButtonNew' at 8;10.", repo.Uedit64.ButtonNewInfo, new RecordItemIndex(0));
            repo.Uedit64.ButtonNew.Click("8;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'UltraEdit64Bit.editorScreen'.", repo.UltraEdit64Bit.editorScreenInfo, new RecordItemIndex(1));
            repo.UltraEdit64Bit.editorScreen.PressKeys(Text);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
