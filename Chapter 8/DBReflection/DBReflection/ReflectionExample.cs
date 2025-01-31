using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DBReflection
{
	class ReflectionExample
	{
		public static bool LoadClassFromSqlDataReader(Object myClass, SqlDataReader sqlReader)
		{
			bool bRetVal;

			if (bRetVal = sqlReader.HasRows)
			{
				sqlReader.Read();

				Type typeOfClass = myClass.GetType();

				Dictionary<String, PropertyInfo> dctNameToPropInfo = new Dictionary<String, PropertyInfo>();

				PropertyInfo[] apinfoPropInfo = typeOfClass.GetProperties();
				foreach(PropertyInfo pInfoItem in apinfoPropInfo)
				{
					dctNameToPropInfo.Add(pInfoItem.Name, pInfoItem);
				}

				Dictionary<String, PropertyInfo> dctFieldToPropInfo = new Dictionary<String, PropertyInfo>();
				IEnumerable<DataMappingAttribute> ienumDtaAttribs = typeOfClass.GetCustomAttributes<DataMappingAttribute>(false);
				foreach (DataMappingAttribute item in ienumDtaAttribs)
				{
					PropertyInfo propInfo = null;
					if (dctNameToPropInfo.TryGetValue(item.m_szPropertyName, out propInfo))
						dctFieldToPropInfo.Add(item.m_szFieldName, propInfo);
				}

				for (int nColIndex = 0; nColIndex < sqlReader.FieldCount; nColIndex++)
				{
					// Get the name of the column
					String szColumnName = sqlReader.GetName(nColIndex);

					PropertyInfo propInfo;

					if (dctFieldToPropInfo.TryGetValue(szColumnName, out propInfo) || dctNameToPropInfo.TryGetValue(szColumnName, out propInfo))
					{
						// Set the class property value to the value in the SqlDataReader
						propInfo.SetValue(myClass, sqlReader.GetValue(nColIndex));
					}
					else
					{
						bRetVal = false;
					}
				}
			}

			return bRetVal;
		}
	}
}
