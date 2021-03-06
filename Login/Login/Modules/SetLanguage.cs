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

namespace Login.Modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SetLanguage recording.
    /// </summary>
    [TestModule("9ffd0d22-c952-427b-8830-db238dbaf377", ModuleType.Recording, 1)]
    public partial class SetLanguage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Login.LoginRepository repository.
        /// </summary>
        public static Login.LoginRepository repo = Login.LoginRepository.Instance;

        static SetLanguage instance = new SetLanguage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetLanguage()
        {
            language = "English";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetLanguage Instance
        {
            get { return instance; }
        }

#region Variables

        string _language;

        /// <summary>
        /// Gets or sets the value of variable language.
        /// </summary>
        [TestVariable("c89face1-642d-47a9-9011-825b5fbf3298")]
        public string language
        {
            get { return _language; }
            set { _language = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$language' on item 'ConnectionManager.Language'.", repo.ConnectionManager.LanguageInfo, new RecordItemIndex(0));
            repo.ConnectionManager.Language.Element.SetAttributeValue("TagValue", language);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
