using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarComparer
{
	static class Extensions
	{
		public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
		{
			return listToClone.Select(item => (T)item.Clone()).ToList();
		}

		public static char TestExtension(this CCar ccCar)
		{
			return ccCar.Name[0];
		}
	}

	public class ListEnumerator<T> : IEnumerator<T>
	{
		readonly List<T> m_lstItems = null;
		List<T>.Enumerator m_lstItemEnumerator;

		public ListEnumerator(List<T> lstItems)
		{
			if (null == lstItems)
				throw new ArgumentNullException("Item List");

			m_lstItems = lstItems;
			m_lstItemEnumerator = m_lstItems.GetEnumerator();
		}

		public T Current
		{
			get
			{
				return m_lstItemEnumerator.Current;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				return m_lstItemEnumerator.Current;
			}
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return m_lstItemEnumerator.MoveNext();
		}

		public void Reset()
		{
			m_lstItemEnumerator = m_lstItems.GetEnumerator();
		}
	}


	public partial class CarForm : Form, IEnumerable<CCar>
	{
		List<CCar> m_lstCars = new List<CCar>();
		List<CMakeModels> m_aMakeAndModels = new List<CMakeModels>();

		private class CMakeModels
		{
			public CMakeModels(String szMake, List<String> aszModels)
			{
				m_szMake = szMake;
				m_lstModels = aszModels;
			}

			readonly String m_szMake;
			readonly List<String> m_lstModels;

			public string Make
			{
				get
				{
					return m_szMake;
				}
			}

			public List<String> Models
			{
				get
				{
					return m_lstModels;
				}
			}
		}

		public CarForm()
		{
			InitializeComponent();

			InitializeInventory();
			InitializeSort();
			InitializeList();

			DisplayCars();
		}

		// Create an inventory of car make and models
		private void InitializeModelInfo()
		{
			CMakeModels[] aMakeAndModels =
			{
				new CMakeModels
				(
					"Fiat", 
					new List<string> { "124 Spider", "500", "500 Abarth", "500c", "500c Abarth", "500e" }
				),

				new CMakeModels
				(
					"Nissan",
					new List<string> { "370Z", "Altima", "Armada", "Frontier Crew Cab", "Maxima", "Pathfinder", "Rogue", "Rogue Sport", "Sentra" }
				),

				new CMakeModels
				(
					"Ford",
					new List<string> { "EcoSport", "Edge", "Expedition", "Explorer", "Fiesta", "Focus", "Fusion", "F150" }
				),

				new CMakeModels
				(
					"Ferrari",
					new List<string> { "488 GTB", "488 Spider", "812 Superfast", "California", "GTC4Lusso", "Portofino" }
				),

				new CMakeModels
				(
					"Bugatti",
					new List<string> { "Veyron", "Type 32", "EB110", "Royale", "Type 101", "EB118", "18/3 Chiron" }
				)
			};

			foreach(CMakeModels item in aMakeAndModels)
			{
				m_aMakeAndModels.Add(item);
			}
		}

		// Using the array of Car Make/Models, generate a list of CCar items
		// with a random max MPH, HP, and mileage.
		private void InitializeInventory()
		{
			InitializeModelInfo();

			m_lstCars.Clear();

			Random rnd = new Random(1);
			foreach(CMakeModels cItem in m_aMakeAndModels)
			{
				String szName = cItem.Make;
				List<String> lstModels = cItem.Models;
				int nCount = lstModels.Count();
				for (int nIx=0; nIx<nCount*3; nIx++)
				{
					int nModelIx = rnd.Next(0, nCount - 1);
					String szModel = lstModels[nModelIx];
					CCar cCarItem = new CCar(szName + " " + szModel, (uint)rnd.Next(65, 250), (uint)rnd.Next(200, 650), (float)rnd.Next(20000, 1500000));

					m_lstCars.Add(cCarItem);
				}
			}
		}

		private void InitializeSort()
		{
			Dictionary<string, CarComparable.CompareType> dctSource = new Dictionary<string, CarComparable.CompareType>(); ;

			dctSource.Add("Name", CarComparable.CompareType.CT_NAME);
			dctSource.Add("Max MPH", CarComparable.CompareType.CT_MAX_MPH);
			dctSource.Add("Horsepower", CarComparable.CompareType.CT_HORSEPOWER);
			dctSource.Add("Price", CarComparable.CompareType.CT_PRICE);

			cmbSortBy.Items.Clear();

			cmbSortBy.DataSource = new BindingSource(dctSource, null);
			cmbSortBy.DisplayMember = "Key";
			cmbSortBy.ValueMember = "Value";
		}

		// Initialize the list control with the inventory items
		private void InitializeList()
		{
			lstvwCars.Clear();
			lstvwCars.View = View.Details;

			lstvwCars.Columns.Add("Name", -2, HorizontalAlignment.Left);
			lstvwCars.Columns.Add("Max MPH", -2, HorizontalAlignment.Right);
			lstvwCars.Columns.Add("Horsepower", -2, HorizontalAlignment.Right);
			lstvwCars.Columns.Add("Price", -2, HorizontalAlignment.Right);
		}

		// Display this list, in order
		private void DisplayCars()
		{
			lstvwCars.Items.Clear();
			IEnumerator<CCar> ienumCars = GetEnumerator();
			while (ienumCars.MoveNext())
			{
				CCar cItem = ienumCars.Current;
				ListViewItem lvItem = lstvwCars.Items.Add(cItem.Name);
				lvItem.SubItems.Add(String.Format("{0}", cItem.MaxMPH));
				lvItem.SubItems.Add(String.Format("{0}", cItem.HorsePower));
				lvItem.SubItems.Add(String.Format("{0:C}", cItem.Price));
			}
		}

		private void OnSort(object sender, EventArgs e)
		{
			CarComparable.CompareType ctType = (CarComparable.CompareType)cmbSortBy.SelectedValue;

			CarComparable ccComp = new CarComparable(ctType, radioAscending.Checked);
			m_lstCars.Sort(ccComp);

			DisplayCars();
		}

		private void OnRemoveDuplicates(object sender, EventArgs e)
		{
			HashSet<CCar> hshCars = new HashSet<CCar>(new CarComparer());
			m_lstCars.ForEach(x => hshCars.Add(x));
			int nDuplicates = m_lstCars.Count - hshCars.Count();
			System.Diagnostics.Trace.WriteLine(String.Format("Eliminated {0} duplicates", nDuplicates));

			m_lstCars.Clear();
			foreach (CCar cCar in hshCars)
				m_lstCars.Add(cCar);

			OnSort(sender, e);
		}

		public IEnumerator<CCar> GetEnumerator()
		{
			return new ListEnumerator<CCar>(m_lstCars);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
