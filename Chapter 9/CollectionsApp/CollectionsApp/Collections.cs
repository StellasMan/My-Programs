using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionsApp
{
	public class Collections
	{
		public void ExerciseArrayList()
		{
			m_arrList.Add("First");
			m_arrList.Add(1);
			m_arrList.Add(3.141592653589);

			foreach(Object objItem in m_arrList)
			{
				Trace.WriteLine(String.Format("{0}: {1}", objItem, objItem.GetType().ToString()));
			}
		}

		public void ExerciseSortedList(Object[] objItems)
		{
			Random rand = objItems[0] as Random;
			EventWaitHandle evHandle = objItems[1] as EventWaitHandle;
			int nCount;
			lock(m_objSortListLock)
			{
				nCount = rand.Next(1, 500);
			}

			for (int nIx=0; nIx<nCount; nIx++)
			{
				lock(m_objSortListLock)
				{
					int nVal = rand.Next(1, 1000);
					try
					{
						m_srtList.Add(nVal, String.Format("{0}", nVal));
					}
					catch(Exception ex)
					{
						Trace.WriteLine(String.Format("Key {0} already exists {1}", nVal, ex.Message));
					}
				}

				System.Threading.Thread.Yield();
			}

			evHandle.Set();	// Signal event
		}

		public void ExerciseHashTable()
		{
			// Creates and initializes a new SortedList.
			SortedList mySL = new SortedList();
			mySL.Add(2, "two");
			mySL.Add(3, "three");
			mySL.Add(1, "one");
			mySL.Add(0, "zero");
			mySL.Add(4, "four");

			// Displays the values of the SortedList.
			Console.WriteLine("The SortedList contains the following values:");
			PrintIndexAndKeysAndValues(mySL);

			// Replaces the values at index 3 and index 4.
			mySL.SetByIndex(0, "III");
			mySL.SetByIndex(4, "IV");

			// Displays the updated values of the SortedList.
			Console.WriteLine("After replacing the value at index 3 and index 4,");
			PrintIndexAndKeysAndValues(mySL);
		}

		public static void PrintIndexAndKeysAndValues(SortedList myList)
		{
			Trace.WriteLine("\t-INDEX-\t-KEY-\t-VALUE-");
			for (int i = 0; i < myList.Count; i++)
			{
				Trace.WriteLine(String.Format("\t[{0}]:\t{1}\t{2}", i, myList.GetKey(i), myList.GetByIndex(i)));
			}
			Trace.WriteLine("");
		}

		public void ExerciseQueue()
		{

		}

		public void ExerciseStack()
		{

		}

		public void ExerciseCustom()
		{
			Tuple<String, String, Person.EN_GENDER>[] aNames =
			{
				new Tuple<String, String, Person.EN_GENDER>("James",		"Smith",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("John",			"Johnson",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Robert",		"Williams", Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Michael",		"Brown",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Brigham",		"Jones",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("David",		"Garcia",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Richard",		"Miller",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Charles",		"Davis",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Joseph",		"Rodriguez",Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Thomas",		"Martinez", Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Christopher",	"Hernandez",Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Daniel",		"Lopez",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Paul",			"Gonzalez", Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Mark",			"Wilson",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Donald",		"Anderson", Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("George",		"Thomas",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Kenneth",		"Taylor",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Stephen",		"Moore",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Edward",		"Jackson",	Person.EN_GENDER.EN_MALE),
				new Tuple<String, String, Person.EN_GENDER>("Brian",		"Martin",	Person.EN_GENDER.EN_MALE),

				new Tuple<String, String, Person.EN_GENDER>("Aracelis",    "Lee",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Apryl",       "Perez",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Annett",      "Thompson",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Alishia",     "Thompson",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Veola",       "White",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Usha",        "Harris",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Toshiko",     "Sanchez",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Theola",      "Clark",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Tashia",      "Ramirez",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Talitha",     "Lewis",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Shery",       "Robinson",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Rudi",        "Walker",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Renetta",     "Young",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Reiko",       "Allen",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Rasheeda",    "King",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Omega",       "Wright",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Obdulia",     "Scott",		Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Mika",        "Torres",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Melaine",     "Nguyen",	Person.EN_GENDER.EN_FEMALE),
				new Tuple<String, String, Person.EN_GENDER>("Meggan",      "Hill",		Person.EN_GENDER.EN_FEMALE)
			};

			if (m_collPersons.Count == 0)
				PopulatePersonList(aNames);

			int nIndx = m_collPersons.Search(new Person("Usha", "Lopez", Person.EN_GENDER.EN_FEMALE, uint.MaxValue));

			m_collPersons.Sort();

			nIndx = m_collPersons.Search(new Person("Usha", "Lopez", Person.EN_GENDER.EN_FEMALE, uint.MaxValue));
			nIndx = m_collPersons.Search(new Person("Ushx", "Lopez", Person.EN_GENDER.EN_FEMALE, uint.MaxValue));

			m_collPersons.AddSorted(new Person("Usha", "Lopez", Person.EN_GENDER.EN_FEMALE, uint.MaxValue));
			m_collPersons.AddSorted(new Person("Ushd", "Lopez", Person.EN_GENDER.EN_FEMALE, uint.MaxValue));
			m_collPersons.AddSorted(new Person("Ushc", "Lopez", Person.EN_GENDER.EN_FEMALE, uint.MaxValue));
			m_collPersons.AddSorted(new Person("Ushe", "Lopez", Person.EN_GENDER.EN_FEMALE, uint.MaxValue));
			m_collPersons.AddSorted(new Person("William", "Young", Person.EN_GENDER.EN_MALE, 25));
			m_collPersons.AddSorted(new Person("Alexander", "Allen", Person.EN_GENDER.EN_MALE, 28));
		}

		private void PopulatePersonList(Tuple<String, String, Person.EN_GENDER>[] aNames)
		{
			m_collPersons.Clear();
			int nCount = aNames.Count();
			Random rand = new Random(DateTime.Now.Millisecond);
			for (int nIx=0; nIx<nCount; nIx++)
			{
				for (int nIy=0; nIy<nCount; nIy++)
				{
					Person perNew = new Person(aNames[nIx].Item1, aNames[nIy].Item2, aNames[nIx].Item3, (uint)rand.Next(1, 80));
					m_collPersons.Add(perNew);
				}
			}
		}

		public ArrayList m_arrList = new ArrayList();
		public SortedList m_srtList = new SortedList();
		private Object m_objSortListLock = new Object();

		public Hashtable m_hshTable = new Hashtable();
		public Queue m_queQueue = new Queue(100, 1.5f);
		public Stack m_stkStack = new Stack();
		public PersonCollection m_collPersons = new PersonCollection();
		public Collection<Person> m_collGenericPerson = new Collection<Person>();
	}

	public class Person : IComparable
	{
		public enum EN_GENDER
		{
			EN_MALE = 0,
			EN_FEMALE
		};

		public Person(String szFirstName, String szLastName, EN_GENDER enGender, uint uiAge)
		{
			FName = szFirstName;
			LName = szLastName;
			Gender = enGender;
			Age = uiAge;
		}

		public Person(Person perPerson)
		{
			FName = perPerson.FName;
			LName = perPerson.LName;
			Gender = perPerson.Gender;
			Age = perPerson.Age;
		}

		public int CompareTo(Object obj)
		{
			if (obj == null) return 1;

			if (obj.GetType() == typeof(Person))
			{
				Person otherPerson = obj as Person;
				int nRetVal = -1;
				if ((Age == uint.MaxValue) || (otherPerson.Age == uint.MaxValue))
				{
					String sThis = String.Format
					(
						"{0}|{1}|{2}",
						LName,
						FName,
						(Gender == EN_GENDER.EN_MALE) ? "M" : "F"
					);

					String sOther = String.Format
					(
						"{0}|{1}|{2}",
						otherPerson.LName,
						otherPerson.FName,
						(otherPerson.Gender == EN_GENDER.EN_MALE) ? "M" : "F"
					);

					return sThis.CompareTo(sOther);
				}
				else
				{
					nRetVal = this.ToString().CompareTo(otherPerson.ToString());
				}

				return nRetVal;
			}
			else
			{
				throw new ArgumentException("Object is not a Person");
			}
		}

		public static Person operator +(Person perSrc, Person perDest)
		{
			Person perNew = new Person(perSrc);
			perNew.Age += perDest.Age;
			return perNew;
		}

		public static bool operator ==(Person perSrc, Person perDest)
		{
			return
				(perSrc.FName == perDest.FName)		&&
				(perSrc.LName == perDest.LName)		&&
				(perSrc.Gender == perDest.Gender)	&&
				(perSrc.Age == perDest.Age);
		}

		public static bool operator !=(Person perSrc, Person perDest)
		{
			return !(perSrc == perDest);
		}

		public override bool Equals(Object obj)
		{
			return obj is Person && this == (Person)obj;
		}

		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		public String FName
		{ get;  }

		public String LName
		{ get; }

		public EN_GENDER Gender
		{ get; }

		public uint Age
		{ get; set;  }

		public override string ToString()
		{
			return String.Format
			(
				"{0}|{1}|{2}|{3}",
				LName,
				FName,
				(Gender == EN_GENDER.EN_MALE) ? "M" : "F",
				Age
			);
		}
	}

	public class PersonCollection : CollectionBase
	{
		public void Add(Person perPerson)
		{
			List.Add(perPerson);
			if (m_bSorted)
			{
				if ((List.Count > 1) && (perPerson.CompareTo(List[List.Count-2]) < 0))
				{
					m_bSorted = false;
				}
			}
		}

		public void AddSorted(Person perPerson)
		{
			if (m_bSorted)
			{
				Tuple<int, int> tplResult = BinarySearch(perPerson);
				if (tplResult.Item1 < 0)
				{
					int nInsert = tplResult.Item2;
					Person perItem = List[nInsert] as Person;
					if (perPerson.CompareTo(perItem) > 0)
						nInsert++;

					Insert(nInsert, perPerson);
				}
			}
		}
		public void Insert(int nIndx, Person perPerson)
		{
			List.Insert(nIndx, perPerson);
			if (m_bSorted)
			{
				if ((nIndx > 0) && (perPerson.CompareTo(List[nIndx-1]) < 0))
				{
					m_bSorted = false;
				}

				if ((nIndx < List.Count-1) && (perPerson.CompareTo(List[nIndx + 1]) > 0))
				{
					m_bSorted = false;
				}
			}
		}

		public void Sort()
		{
			InnerList.Sort(null);
			m_bSorted = true;
		}

		public int Search(Person perItem)
		{
			return m_bSorted ? BinarySearch(perItem).Item1 : SeqSearch(perItem);
		}

		private Tuple<int, int> BinarySearch(Person perItem)
		{
			int nIndxItem = -1;
			uint uiLower = 0;
			uint uiUpper = (uint)List.Count - 1;

			if (List.Count > 0)
			{
				bool bFound = false;
				uint uiPrevCurr = uint.MaxValue;
				uint uiLoopCount = 0;

				do
				{
					uint uiCurrent = (uiLower + uiUpper) / 2;
					if (uiCurrent == uiPrevCurr)
					{
						uiLower++;
						uiCurrent++;
					}
					uiPrevCurr = uiCurrent;
					Person perCurrent = List[(int)uiCurrent] as Person;
					Trace.WriteLine
						(String.Format
							(
								"Lower[{0}] {1}; Current[{2}] {3}; Upper[{4}] {5}; ",
								uiLower, List[(int)uiLower],
								uiCurrent, List[(int)uiCurrent],
								uiUpper, List[(int)uiUpper]
							)
						);
					int nCompare = perItem.CompareTo(perCurrent);
					if (nCompare < 0)
					{
						uiUpper = uiCurrent;
					}
					else if (nCompare > 0)
					{
						uiLower = uiCurrent;
					}
					else
					{
						nIndxItem = (int)uiCurrent;
						bFound = true;
					}

					uiLoopCount++;
				} while (!bFound && (uiLower != uiUpper));

				Trace.WriteLine
				(
					bFound	? String.Format("Found {0} in {1} iterations", List[nIndxItem], uiLoopCount)
							: String.Format("Unable to find {0} after {1} iterations", perItem, uiLoopCount)
				);
			}

			return new Tuple<int, int>(nIndxItem, (int)uiLower);
		}

		private int SeqSearch(Person perSearch)
		{
			int nIndxItem = -1;
			ArrayList lstItems = InnerList;
			for (int nIx = 0; nIx < lstItems.Count; nIx++)
			{
				if (((Person)lstItems[nIx]).CompareTo(perSearch) == 0)
				{
					nIndxItem = nIx;
					break;
				}
			}

			return nIndxItem;
		}

		bool m_bSorted = false;
	}
}
