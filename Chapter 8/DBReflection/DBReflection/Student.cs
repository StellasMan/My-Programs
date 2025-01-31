using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBReflection
{
	[Custom(false, "Hello World", CustomAttribute.MyCustomeAttribEnum.White)]
	public class Student
    {
		public Student(int nId = -1)
		{
			m_PersonId = nId;
		}

		public bool GetStudent(int nPersonId)
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

        public int m_PersonId		{ get; set; }
        public String m_FirstName	{ get; set; }
        public String m_LastName	{ get; set; }
        public String m_Address		{ get; set; }
        public String m_City		{ get; set; }
        public String m_State		{ get; set; }
        public String m_ZipCode		{ get; set; }
    }
}
