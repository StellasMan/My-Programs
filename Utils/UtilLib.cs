using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilLib
{
	class KVPComparer : IComparer<KeyValuePair<String, Int32>>
	{
		public int Compare(KeyValuePair<String, Int32> x, KeyValuePair<String, Int32> y)
		{
			int nRetVal = 0;
			if (!String.IsNullOrEmpty(x.Key) && !String.IsNullOrEmpty(y.Key))
			{
				int nLeft, nRight;

				if (!int.TryParse(x.Key, out nLeft))
				{
					throw new ArgumentException(String.Format("{0} is not a valid integer", x.Key), "Arg1");
				}
				else if (!int.TryParse(y.Key, out nRight))
				{
					throw new ArgumentException(String.Format("{0} is not a valid integer", y.Key), "Arg2");
				}
				else
				{
					nRetVal = nLeft.CompareTo(nRight);
				}
			}

			return nRetVal;
		}
	}

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
			// by doing nonsens divisions and multiplications

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

		public static List<Int32> GetCPUPerformance()
		{
			List<KeyValuePair<String, Int32>> lstCPUUsage = new List<KeyValuePair<string, Int32>>();
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * from Win32_PerfFormattedData_PerfOS_Processor");
			ManagementObjectCollection mgmtObjects = searcher.Get();
			if (mgmtObjects.Count > 0)
			{
				foreach (ManagementObject obj in mgmtObjects)
				{
					ulong? ulUsage = obj["PercentProcessorTime"] as ulong?;
					String csName = obj["Name"] as String;

					if (!csName.Contains("Total"))
					{
						KeyValuePair<String, Int32> kvp = new KeyValuePair<string, Int32>(csName, (Int32)ulUsage.Value);
						lstCPUUsage.Add(kvp);
					}
				}
			}

			KVPComparer kvpCompare = new KVPComparer();
			lstCPUUsage.Sort(kvpCompare);

			return lstCPUUsage.Select(x => x.Value).ToList<Int32>();
		}
	}
}
