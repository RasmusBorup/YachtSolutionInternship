using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YachtSolution.GUILayer;

namespace YachtSolution
{
    /// <summary>
    /// This is the class Program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// This is the main entry point for the windows form application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}