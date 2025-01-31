using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilLib
{
    public static class UtilityClass
    {
        public delegate Func<AutoResetEvent, double> AsyncFunc();
        public static double DoTask(Task<double> taskItem)
        {
            return 0;
        }

        public static double DoIntensiveCalculations()
        {
            // We are simulating intensive calculations 
            // by doing nonsense divisions and multiplications

            double result = 10000d;
            var maxValue = Int32.MaxValue >> 4;
            for (int i = 1; i < maxValue; i++)
            {
                if (i % 2 == 0)
                {
                    result /= i;
                }
                else
                {
                    result *= i;
                }
            }
            return result;
        }

        public static void DisplayTextImmediate(TextBox txtCtrl, String csText)
        {
            txtCtrl.Text = csText;
            txtCtrl.Invalidate();
            txtCtrl.Refresh();
            Application.DoEvents();
        }
    }
}
