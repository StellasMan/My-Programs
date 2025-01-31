using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionTest
{
	public static class IntegerExt
	{
		public static int Cube(this int nNum)
		{
			return (nNum * nNum * nNum);
		}
	}
}
