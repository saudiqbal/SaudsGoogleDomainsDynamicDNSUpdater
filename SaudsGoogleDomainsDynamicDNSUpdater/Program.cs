using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaudsGoogleDomainsDynamicDNSUpdater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            if (args.Length == 1 && (args[0] == "/StartMinimized" || args[0] == "-minimized"))
            {
                form1.Visible = true;
                form1.WindowState = FormWindowState.Minimized;
            }
                //form1.WindowState = FormWindowState.Minimized;
            //form1.Visible = true;
            Application.Run(form1);
            
            //Application.Run(new Form1());
        }
    }
}
