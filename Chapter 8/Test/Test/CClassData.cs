using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest
{
    public class CClassData
    {
        public CClassData()
        {
        }

        public CClassData(String csName)
        {
            m_csStudentName = csName;
        }

        private enum ENUMPRIVATEVALS
        {
            ENUMVAL1 = 1,
            ENUMVAL2,
            ENUMVAL3
        };

        public enum ENUMPUBLICVALS
        {
            ENUMVAL1 = 1,
            ENUMVAL2,
            ENUMVAL3
        };

        protected String m_csStudentName;
    }

    public class CClassProperties
    {
        public CClassProperties(String sName)
        {
            m_sName = sName;
        }

        public String Name
        {
            get 
            {
                return m_sName;
            }
        }

        String m_sName;
    }
}
