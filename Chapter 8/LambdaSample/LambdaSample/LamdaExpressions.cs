using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSample
{
	class LamdaExpressions
	{
		public delegate void GenericStringMethod(String s);	// Define a delegate that takes a single string parameter and returns void

		public static void WriteToConsoleForward(String stringToWrite)
		{
			Console.WriteLine("This is my string {0}", stringToWrite);
		}

		public static GenericStringMethod myMethod;

		public static void WriteWithMethod(GenericStringMethod genMethod, String sInput)
		{
			genMethod(sInput);
		}
	}
}
