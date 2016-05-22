﻿using System;
using System.Windows.Forms;
using mRemoteNG.UI.Forms;

namespace mRemoteNG.App
{
    public static class ProgramRoot
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Startup.InitializeProgram();
            var mainForm = new frmMain();
            frmMain.Default = mainForm;
            Application.Run(mainForm);
        }
    }
}