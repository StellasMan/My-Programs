using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqQuery
{
	public partial class LinqTestForm : Form
	{
		public class Person
		{
			public UInt64 PersonID;
			public String FName;
			public String LName;
			public String Address;
			public String City;
			public String State;
			public String Zip;
			public DateTime BirthDate;

			public UInt64 SpouseID;
			public UInt64 FatherID;
			public UInt64 MotherID;
		}

		public class Employee : Person
		{
			public UInt64 EmployeeID;
			public UInt64 ManagerID;

			public DateTime StartDate;
			public DateTime LeaveDate;

			public float AnnualSalary;
		}

		List<Person> Persons;
		List<Employee> Employees;

		public LinqTestForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Persons = new List<Person>()
			{
				new Person()
				{
					PersonID = 1,
					FName = "Adrian",
					LName = "Armstrong",
					Address="2210 Garrett Drive",
					City="Killeen",
					State="TX",
					Zip="76543",
					BirthDate=new DateTime(2002, 12, 09),

					SpouseID=0,
					FatherID=4,
					MotherID=3
				},

				new Person()
				{
					PersonID = 2,
					FName = "Ariel",
					LName = "Armstrong",
					Address="12415 Somewhere",
					City="Manila",
					State="PH",
					Zip="76543",
					BirthDate=new DateTime(2001, 06, 13),

					SpouseID=0,
					FatherID=4,
					MotherID=3
				},

				new Person()
				{
					PersonID = 3,
					FName = "Stella",
					LName = "Armstrong",
					Address="2210 Garrett Drive",
					City="Killeen",
					State="TX",
					Zip="76543",
					BirthDate=new DateTime(1970, 12, 26),

					SpouseID=4,
					FatherID=0,
					MotherID=0
				}

			};

			Employees = new List<Employee>()
			{
				new Employee()
				{
					PersonID = 4,
					FName = "Jeff",
					LName = "Armstrong",
					Address="2210 Garrett Drive",
					City="Killeen",
					State="TX",
					Zip="76543",
					BirthDate=new DateTime(1954, 10, 29),
					SpouseID=3,
					FatherID=0,
					MotherID=0,

					EmployeeID = 1,
					ManagerID = 2,

					StartDate=new DateTime(2015, 7, 7),
					AnnualSalary = 103000
				},

				new Employee()
				{
					PersonID = 5,
					FName = "Jamie",
					LName = "Forgan",
					Address="2291 Wood Oak Drive",
					City="Herndon",
					State="VA",
					Zip="20171-2823",
					BirthDate=new DateTime(1976, 06, 23),
					SpouseID=0,
					FatherID=0,
					MotherID=0,

					EmployeeID=2,
					ManagerID=0,
					StartDate=new DateTime(1992, 07, 08),
					AnnualSalary=175750
				},
			};

			OnTest(sender, e);
		}

		private void OnTest(object sender, EventArgs evtArgs)
		{
			List<String> lstLines = new List<String>();

			// Simple query
			var PersonList =	from item in Persons
								// where item.FName=="Jeff"
								orderby item.LName ascending, item.FName descending
								select item;

			foreach (var item in PersonList)
			{
				String sValue = String.Format("First Name: {0}, Last Name: {1}", item.FName, item.LName);
				Trace.WriteLine(sValue);
				lstLines.Add(sValue);
			}

			// Join
			var FamilyList =	from p in Persons
								join e in Employees
								on p.PersonID equals e.SpouseID
								select new { EmpID = e.EmployeeID, EmpFName = e.FName, EmpLName = e.LName, SpouseID = p.PersonID, SpouseFName = p.FName, SpouseLName = p.LName };

			lstLines.Add("-------------------");
			
			foreach (var item in FamilyList)
			{
				String sValue = String.Format("Emp. ID: {0}, First Name: {1}, Last Name: {2}, Spouse ID: {3}, Spouse FName: {4}, Spouse LName: {5}", 
					item.EmpID, item.EmpFName, item.EmpLName, item.SpouseID, item.SpouseFName, item.SpouseLName);

				Trace.WriteLine(sValue);
				lstLines.Add(sValue);
			}

			rtText.Lines = lstLines.ToArray();
		}
	}
}
