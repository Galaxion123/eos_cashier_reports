﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cashier_Reports__end_of_shift_
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
            Application.Run(new EOSReports());
        }
    }
}
