using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace TempTest
{
	public class ExcelIntfc
	{
		private Excel._Application m_excelApp;
		private Excel.Workbook m_wrkBook;
		private readonly Excel.Worksheet m_wrkSheet;

		public ExcelIntfc()
		{
			m_excelApp = new Excel.Application();
			m_wrkBook = m_excelApp.Workbooks.Add();
			m_wrkSheet = m_wrkBook.Worksheets[1];
		}

		public void Display(bool bDisplay=true)
		{
			m_excelApp.Visible = bDisplay;
		}

		public Excel.Workbook WorkBook
		{
			get { return m_wrkBook; }
		}

		public Excel.Worksheet Worksheet
		{
			get { return m_wrkSheet; }
		}

		public void Close()
		{
			if ((m_excelApp != null) && (m_wrkBook != null) && (m_wrkSheet != null))
			{
				try
				{
					m_wrkBook.Close(false);
					m_excelApp.Quit();
				}
				catch(Exception ex)
				{
					Console.WriteLine("Exception closing Excel\n{0}", ex.Message);
				}

				m_wrkBook = null;
				m_excelApp = null;
			}
		}
	}
}
