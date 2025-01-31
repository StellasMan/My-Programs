using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBReflection
{
	[DataMapping("FirstName", "m_FName")]
	[DataMapping("LastName", "m_LName")]
	[DataMapping("Address", "m_Address")]
	[DataMapping("City", "m_City")]
	[DataMapping("State", "m_State")]
	[DataMapping("ZipCode", "m_ZipCode")]
	public class Person
    {
		public Person(int nId = -1)
		{
			PersonId = nId;
		}

		public bool GetPerson(int nPersonId)
		{
			// Open the connection to the database.
			SqlConnection cn = new SqlConnection("Server=(local); Database=MSDNSample; Trusted_Connection=true;");

			cn.Open();

			// Retrieve the record
			SqlCommand cmd = new SqlCommand(
					String.Format("SELECT * FROM Student WHERE PersonId = {0}", nPersonId), 
					cn);

			SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

			return ReflectionExample.LoadClassFromSqlDataReader(this, dr);
		}

        public int PersonId			{ get; set; }
        public String m_FName		{ get; set; }
        public String m_LName		{ get; set; }
        public String m_Address		{ get; set; }
        public String m_City		{ get; set; }
        public String m_State		{ get; set; }
        public String m_ZipCode		{ get; set; }
    }
}
