using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTest
{
	public class MyCustomAttribute : System.Attribute
	{
		public MyCustomAttribute()
		{
			Property1 = false;
			Property2 = String.Empty;
			Property3 = MyCustomAttributeEnum.red;
		}

		public MyCustomAttribute(bool bProp1, String sProp2, MyCustomAttributeEnum enumProp3)
		{
			Property1 = bProp1;
			Property2 = sProp2;
			Property3 = enumProp3;
		}

		public enum MyCustomAttributeEnum
		{
			red,
			white,
			blue
		};

		public bool Property1 { get; set; }
		public String Property2 { get; set; }
		public MyCustomAttributeEnum Property3 { get; set; }
	}

	[MyCustom(Property1 =false, Property2 = "Hello World", Property3 = MyCustomAttribute.MyCustomAttributeEnum.blue)]
	public class AttribTest
	{
	}
}
