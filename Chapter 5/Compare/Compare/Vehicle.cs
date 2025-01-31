using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
	public abstract class Vehicle : IComparable<Vehicle>, IEquatable<Vehicle>
	{
		public Vehicle(
			VEHICLE_TYPE vtVehicleType,
			String szMake,
			String szModel,
			UInt16 uiYear,
			float flCost,
			UInt16 uiMaxSpeed
			)
		{
			m_vtVehicleType = vtVehicleType;
			m_uiMaxSpeed = uiMaxSpeed;
			m_flCost = flCost;
			m_szMake = szMake;
			m_szModel = szModel;
			m_uiYear = uiYear;
		}

		public enum VEHICLE_TYPE
		{
			VT_MOTORCYCLE,
			VT_CAR,
			VT_TRUCK,
			VT_VAN
		}

		// ***** IComparable interface *****
		public int CompareTo(Vehicle src)
		{
			String szMakeModel = VehicleTypeAsString + "|" + m_szMake + "|" + m_szModel + "|" + String.Format("{0}", m_uiYear);
			return szMakeModel.CompareTo(src.VehicleTypeAsString + "|" + src.m_szMake + "|" + src.m_szModel + "|" + String.Format("{0}", src.m_uiYear));
		}

		// ***** IEquatable interface *****
		public bool Equals(Vehicle src)
		{
			return (CompareTo(src) == 0);
		}

		public VEHICLE_TYPE VehicleType
		{
			get { return m_vtVehicleType; }
		}

		public String VehicleTypeAsString
		{
			get
			{
				String szVehicleType = "UNKNOWN";

				switch(m_vtVehicleType)
				{
					case VEHICLE_TYPE.VT_MOTORCYCLE:
						szVehicleType = "CYCLE";
						break;

					case VEHICLE_TYPE.VT_CAR:
						szVehicleType = "CAR";
						break;

					case VEHICLE_TYPE.VT_TRUCK:
						szVehicleType = "TRUCK";
						break;

					case VEHICLE_TYPE.VT_VAN:
						szVehicleType = "VAN";
						break;
				}

				return szVehicleType;
			}
		}

		public UInt16 Speed
		{
			get { return m_uiMaxSpeed; }
		}

		public float Cost
		{
			get { return m_flCost; }
		}

		public String Make
		{
			get { return m_szMake; }
		}

		public String Model
		{
			get { return m_szModel; }
		}

		public UInt16 Year
		{
			get { return m_uiYear; }
		}

		public abstract String SpecialFeature1();

		private VEHICLE_TYPE m_vtVehicleType;
		private readonly UInt16 m_uiMaxSpeed;
		private readonly float m_flCost;
		private readonly String m_szMake;
		private readonly String m_szModel;
		private readonly UInt16 m_uiYear;
	}

	public class VehicleComparer : IComparer<Vehicle>
	{
		public VehicleComparer(VehicleComparer.SortType srtType, bool bSortAscending)
		{
			m_stCompareType = srtType;
			m_bSortAscending = bSortAscending;
		}

		public enum SortType : byte
		{
			ST_MAKEMODEL,
			ST_PRICE,
			ST_TOPSPEED
		}

		// ***** IComparer interface *****
		public int Compare(Vehicle x, Vehicle y)
		{
			int nRetVal = 0;

			switch (m_stCompareType)
			{
				case SortType.ST_MAKEMODEL:
					nRetVal = String.Compare(String.Format("{0}:{1}", x.Make, x.Model), String.Format("{0}:{1}", y.Make, y.Model));
					break;

				case SortType.ST_PRICE:
					nRetVal = (x.Cost == y.Cost) ? 0 :
								(x.Cost < y.Cost) ? -1 : 1;
					break;

				case SortType.ST_TOPSPEED:
					nRetVal = (x.Speed == y.Speed) ? 0 :
								(x.Speed < y.Speed) ? -1 : 1;
					break;
			}

			return m_bSortAscending ? nRetVal : -nRetVal;
		}

		private readonly SortType m_stCompareType;
		private readonly bool m_bSortAscending;
	}
}
