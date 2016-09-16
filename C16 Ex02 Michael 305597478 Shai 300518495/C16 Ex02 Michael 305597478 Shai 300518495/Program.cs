using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
