using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RPElite
{
    static class Program
    {
        public static readonly bool isDebug = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Overlay());
        }
    }
}
