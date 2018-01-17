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
    ///The LoginAdmin recording.
    /// </summary>
    [TestModule("10bb3c71-e099-4316-8ae3-fb7bd5443b28", ModuleType.Recording, 1)]
    public partial class LoginAdmin : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Login.LoginRepository repository.
        /// </summary>
        public static Login.LoginRepository repo = Login.LoginRepository.Instance;

        static LoginAdmin instance = new LoginAdmin();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoginAdmin()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LoginAdmin Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'admin' on item 'ConnectionManager.Username'.", repo.ConnectionManager.UsernameInfo, new RecordItemIndex(0));
            repo.ConnectionManager.Username.Element.SetAttributeValue("Value", "admin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'superduper' on item 'ConnectionManager.Password'.", repo.ConnectionManager.PasswordInfo, new RecordItemIndex(1));
            repo.ConnectionManager.Password.Element.SetAttributeValue("Value", "superduper");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ConnectionManager.LogIn'.", repo.ConnectionManager.LogInInfo, new RecordItemIndex(2));
            repo.ConnectionManager.LogIn.PerformClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
