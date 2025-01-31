using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads
{
    static class Program
    {
        static ThreadingForm thrdForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                thrdForm = new ThreadingForm();
                Application.Run(thrdForm);
            }
            catch (System.Threading.ThreadAbortException ex)
            {
                System.Diagnostics.Trace.WriteLine(String.Format("{0}", ex.Message));
            }
        }
    }
}
