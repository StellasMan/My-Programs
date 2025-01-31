using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaSample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void StringReverse(String s)
		{
			IEnumerable<char> ienumChars = s.Reverse();
			foreach (char ch in ienumChars)
			{
				Console.Write(ch);
			}
			Console.Write("\n");
		}

		private void StringRandom(String s)
		{
			DateTime dtNow = DateTime.Now;
			Random rand = new Random(dtNow.Millisecond);

			while (s.Length > 0)
			{
				int nIndx = rand.Next(s.Length);
				char ch = s[nIndx];
				s = s.Remove(nIndx, 1);

				Console.Write(ch);
			}
			Console.Write("\n");
		}

		private void OnStart(object sender, EventArgs e)
		{
			LamdaExpressions lambdaTest = new LamdaExpressions();
			LamdaExpressions.myMethod = LamdaExpressions.WriteToConsoleForward;

			LamdaExpressions.myMethod += StringReverse;
			LamdaExpressions.myMethod += StringRandom;
			LamdaExpressions.myMethod += (s) => Console.WriteLine(String.Format("*** Anonymous Method '{0}' ***", s));

			LamdaExpressions.myMethod("Hello World");
			LamdaExpressions.myMethod("A man a plan a canal Panama");

			LamdaExpressions.WriteWithMethod(
				(s) => Console.WriteLine(s),
				"Hello World");
		}
	}
}
