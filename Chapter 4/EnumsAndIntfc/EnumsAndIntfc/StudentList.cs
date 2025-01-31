using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempTest
{
	class StudentList : IEnumerable
	{
		private List<Student> m_lstStudents = new List<Student>();

		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
