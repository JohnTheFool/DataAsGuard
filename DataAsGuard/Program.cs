﻿using DataAsGuard.Profiles;
using DataAsGuard.Viewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Home());
            //Application.Run(new Test());
            Application.Run(new Login());
            //Application.Run(new MetaAdmin());
        }
    }
}
