using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CircleTest4
{
    static class CircleTest4
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CircleTest4Form());
        }
    }
}
