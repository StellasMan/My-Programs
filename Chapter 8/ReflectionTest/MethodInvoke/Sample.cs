using System;
using System.Diagnostics;

namespace MethodInvoke
{
	[Serializable()]
	public class Sample
	{
		public enum SampleEnum
		{
			SE_VALUE1 = 1,
			SE_VALUE2 = 200,
			SE_VALUE3 = 300
		};

		public Sample()
		{
			Random rand = new Random(DateTime.Now.Millisecond);
			nValue1 = rand.Next(1, 100);
			nValue2 = rand.Next(1, 100);
		}

		public Sample(int nVal1, int nVal2)
		{
			nValue1 = nVal1;
			nValue2 = nVal2;
		}

		public int Add()
		{
			Trace.WriteLine(String.Format("Add(); {1} + {2} = {0}", Value1 + Value2, Value1, Value2));
			return Value1 + Value2;
		}

		public int Add(int nVal1, int nVal2)
		{
			Trace.WriteLine(String.Format("Add(int, int); {1} + {2} = {0}", nVal1+nVal2, nVal1, nVal2));
			return nVal1 + nVal2;
		}

		public int Value1
		{
			get { return nValue1;	}
			set { nValue1 = value;  }
		}

		public int Value2
		{
			get { return nValue2;	}
		}

		private int nValue1;
		private int nValue2;
	}
}
