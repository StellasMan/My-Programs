using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComparer
{
	public class CarComparer : IEqualityComparer<CCar>
	{
		public bool Equals(CCar ccCarX, CCar ccCarY)
		{
			if ((ccCarX == null) || (ccCarY == null))
				throw new ArgumentException("CarComparer::Equals: Invalid object type");

			CarComparable cComp = new CarComparable(CarComparable.CompareType.CT_NAME, true);
			return (cComp.Compare(ccCarX, ccCarY) == 0);
		}

		public int GetHashCode(CCar ccCar)
		{
			int nHash = 0;
			char[] aChars = ccCar.Name.ToCharArray();
			foreach (char ch in aChars)
			{
				nHash += (int)ch;
				nHash %= 32;
			}

			return nHash;
		}
	}

	public class CarComparable : IComparer<CCar>
	{
		public enum CompareType
		{
			CT_NAME = 1,
			CT_MAX_MPH,
			CT_HORSEPOWER,
			CT_PRICE,
			CT_MAX
		}

		private readonly CompareType m_ctCompareType = CompareType.CT_NAME;
		private readonly bool m_bAscending = true;

		public CarComparable(CompareType ctCompareType, bool bAscending)
		{
			if (((int)ctCompareType <= 0) || (ctCompareType >= CompareType.CT_MAX))
				throw new ArgumentOutOfRangeException("Compare Type");

			m_ctCompareType = ctCompareType;
			m_bAscending = bAscending;
		}

		public int Compare(CCar x, CCar y)
		{
			int nRetVal = 0;

			switch(m_ctCompareType)
			{
				case CompareType.CT_NAME:
					nRetVal = String.Compare(x.Name, y.Name);
					break;

				case CompareType.CT_MAX_MPH:
					nRetVal =	(x.MaxMPH < y.MaxMPH) ? -1	:
								(x.MaxMPH > y.MaxMPH) ? 1	: 0;
					break;

				case CompareType.CT_HORSEPOWER:
					nRetVal =	(x.HorsePower < y.HorsePower) ? -1 :
								(x.HorsePower > y.HorsePower) ? 1 : 0;
					break;

				case CompareType.CT_PRICE:
					nRetVal =	(x.Price < y.Price) ? -1 :
								(x.Price > y.Price) ? 1 : 0;
					break;
			}

			return m_bAscending ? nRetVal : -nRetVal;
		}
	}

	public class CCar : IEquatable<CCar>, ICloneable
	{
		readonly string m_szName;
		readonly uint m_uiMaxMPH;
		readonly uint m_uiHP;
		readonly float m_flPrice;

		public string Name { get { return m_szName; } }
		public uint MaxMPH { get { return m_uiMaxMPH; } }
		public uint HorsePower { get { return m_uiHP; } }
		public float Price { get { return m_flPrice; } }

		public CCar(String szName, uint uiMaxMPH, uint uiHP, float flPrice)
		{
			m_szName = szName;
			m_uiMaxMPH = uiMaxMPH;
			m_uiHP = uiHP;
			m_flPrice = flPrice;
		}

		public CCar(CCar ccCarOther)
		{
			m_szName = ccCarOther.Name;
			m_uiMaxMPH = ccCarOther.MaxMPH;
			m_uiHP = ccCarOther.HorsePower;
			m_flPrice = ccCarOther.Price;
		}

		bool IEquatable<CCar>.Equals(CCar ccCarOther)
		{
			return String.Equals(Name, ccCarOther.Name, StringComparison.OrdinalIgnoreCase);
		}

		object ICloneable.Clone()
		{
			return new CCar(this);
		}
	}
}
