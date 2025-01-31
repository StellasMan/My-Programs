using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBReflection
{
	public class CustomAttribute : System.Attribute
	{
		public CustomAttribute(bool bProp1, String szProp2, MyCustomeAttribEnum enumProp3)
		{
			Prop1 = bProp1;
			Prop2 = szProp2;
			Prop3 = enumProp3;
		}

		public CustomAttribute() : this(false, String.Empty, MyCustomeAttribEnum.Red)
		{

		}

		public enum MyCustomeAttribEnum
		{
			Red,
			White,
			Blue
		};

		public bool Prop1 { get;  }
		public String Prop2 { get; }
		public MyCustomeAttribEnum Prop3 { get; }
	}
}
