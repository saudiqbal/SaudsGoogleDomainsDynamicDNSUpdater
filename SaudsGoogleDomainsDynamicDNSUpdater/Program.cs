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
            bool result;
            var mutex = new System.Threading.Mutex(true, "f49da1b0-6675-4ecd-ad39-fd2172b545fc", out result);
            if (!result)
            {
                MessageBox.Show("Another instance of DNS updater is already running.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length != 0)
            {
                Application.Run(new Form1(args[0]));
            }
            else
            {
                Application.Run(new Form1("normalState"));
            }
            GC.KeepAlive(mutex);
        }
    }
}
