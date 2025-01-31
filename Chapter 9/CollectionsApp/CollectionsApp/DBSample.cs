using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CollectionsApp
{
	public class DBSample
	{
		public void TestConnection()
		{
			String connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.Customers", sqlConnection);
				cmd.CommandType = System.Data.CommandType.Text;
				Object objResult = cmd.ExecuteScalar();
				Trace.WriteLine(String.Format("There are {0} records in the Customer table", objResult));
				
				cmd.CommandText = "SELECT * FROM dbo.Customers";
				using (SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
				{
					while (reader.Read())
					{
						for (int nIx = 0; nIx < reader.FieldCount; nIx++)
						{
							Trace.Write(String.Format("{0} ", reader.GetName(nIx)));
						}
						Trace.WriteLine("");

						if (reader.HasRows)
						{
							while (reader.Read())
							{
								for (int nIx = 0; nIx < reader.FieldCount; nIx++)
								{
									Trace.Write(String.Format("{0} ", reader.GetValue(nIx)));
								}
								Trace.WriteLine("");
							}
						}
					}
				}
			}
		}

		public void TestXmlConnection()
		{
			String connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Customers FOR XML AUTO, XMLDATA", sqlConnection);
				cmd.CommandType = System.Data.CommandType.Text;
				using (System.Xml.XmlReader xmlReader = cmd.ExecuteXmlReader())
				{
					while (xmlReader.Read())
					{
						switch (xmlReader.NodeType)
						{
							case XmlNodeType.Element:
								Trace.WriteLine(String.Format("<{0}>", xmlReader.Name));
								break;

							case XmlNodeType.Text:
								Trace.WriteLine(xmlReader.Value);
								break;

							case XmlNodeType.CDATA:
								Trace.WriteLine(String.Format("<![CDATA[{0}]]>", xmlReader.Value));
								break;

							case XmlNodeType.ProcessingInstruction:
								Trace.WriteLine(String.Format("<?{0} {1}?>", xmlReader.Name, xmlReader.Value));
								break;

							case XmlNodeType.Comment:
								Trace.WriteLine(String.Format("<!--{0}-->", xmlReader.Value));
								break;

							case XmlNodeType.XmlDeclaration:
								Trace.WriteLine(String.Format("<?xml version='1.0'?>"));
								break;

							case XmlNodeType.Document:
								break;

							case XmlNodeType.DocumentType:
								Trace.WriteLine(String.Format("<!DOCTYPE {0} [{1}]", xmlReader.Name, xmlReader.Value));
								break;

							case XmlNodeType.EntityReference:
								Trace.WriteLine(String.Format(xmlReader.Name));
								break;

							case XmlNodeType.EndElement:
								Trace.WriteLine(String.Format("</{0}>", xmlReader.Name));
								break;
						}
					}
				}
			}
		}
	}
}
