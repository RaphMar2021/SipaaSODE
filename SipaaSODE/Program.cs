using SipaaSODE.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE
{
    internal static class Program
    {
        public static Desktop desktop;
        public static List<App> installedApps = new List<App>();
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("SODE Beta is starting...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            desktop = new Desktop();
            Application.Run(desktop);
        }
    }
}
