using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
	public class Car : Vehicle
	{
		public Car
		(
			String szMake,
			String szModel,
			UInt16 uiYear,
			float flCost,
			UInt16 uiMaxSpeed,
			bool bIsHybrid
		)
		: base(VEHICLE_TYPE.VT_CAR, szMake, szModel, uiYear, flCost, uiMaxSpeed)
		{
			m_bIsHybrid = bIsHybrid;
		}

		public bool IsHybrid
		{
			get { return m_bIsHybrid; }
		}

		public override string SpecialFeature1()
		{
			return String.Format("Hybrid: {0}", m_bIsHybrid ? "Yes" : "No");
		}

		protected readonly bool m_bIsHybrid;
	}

	public class Truck : Vehicle
	{
		public Truck
		(
			String szMake,
			String szModel,
			UInt16 uiYear,
			float flCost,
			UInt16 uiMaxSpeed,
			UInt16 uiMaxPayload
		)
		: base(VEHICLE_TYPE.VT_TRUCK, szMake, szModel, uiYear, flCost, uiMaxSpeed)
		{
			m_uiMaxPayload = uiMaxPayload;
		}

		public UInt16 MaxPayload
		{
			get { return m_uiMaxPayload; }
		}

		protected readonly UInt16 m_uiMaxPayload;

		public override string SpecialFeature1()
		{
			return String.Format("Payload: {0}", m_uiMaxPayload);
		}
	}

	public class Motorcycle : Vehicle
	{
		public Motorcycle
		(
			String szMake,
			String szModel,
			UInt16 uiYear,
			float flCost,
			UInt16 uiMaxSpeed,
			byte byMaxPassengers
		)
		: base(VEHICLE_TYPE.VT_MOTORCYCLE, szMake, szModel, uiYear, flCost, uiMaxSpeed)
		{
			m_byMaxPassengers = byMaxPassengers;
		}

		public byte MaxPassengers
		{
			get { return m_byMaxPassengers; }
		}

		protected readonly byte m_byMaxPassengers;

		public override string SpecialFeature1()
		{
			return String.Format("Passengers: {0}", m_byMaxPassengers);
		}
	}


}
