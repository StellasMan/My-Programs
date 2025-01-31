using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEntry
{
	public interface IShape
	{
		int SideCount { get; }
		RectangleF Bounds { get; }
	}
	public class Ellipse : IShape
	{
		public Ellipse(RectangleF rctRect)
		{
			float flVal1 = 0.000001f / 0.1f;
			float flVal2 = 0.001f * 0.01f;

			m_flTolerance = Math.Abs(flVal1 - flVal2);

			m_rctfLocation = NormalizeRect(rctRect);
		}

		public Ellipse(int nUpperLeftX, int nUpperLeftY, int nWidth, int nHeight)
		: this(new RectangleF(new PointF(nUpperLeftX, nUpperLeftY), new SizeF(nWidth, nHeight)))
		{
		}

		private RectangleF m_rctfLocation { get; set; }
		protected float m_flTolerance = 0.0f;

		int IShape.SideCount
		{
			get
			{
				return 0;
			}
		}

		RectangleF IShape.Bounds
		{
			get
			{
				return m_rctfLocation;
			}
		}

		private RectangleF NormalizeRect(RectangleF rctRect)
		{
			if (Math.Abs(rctRect.Width) <= m_flTolerance)
			{
				throw new ArgumentOutOfRangeException("Width", String.Format("Rectangle width has a value of {0:0.00}. Values cannot be zero.", rctRect.Width));
			}

			if (Math.Abs(rctRect.Height) <= m_flTolerance)
			{
				throw new ArgumentOutOfRangeException("Height", String.Format("Rectangle height has a value of {0:0.00}. Values cannot be zero.", rctRect.Height));
			}

			rctRect.X = Math.Min(rctRect.Left, rctRect.Right);
			rctRect.Y = Math.Min(rctRect.Top, rctRect.Bottom);
			rctRect.Width = Math.Abs(rctRect.Width);
			rctRect.Height = Math.Abs(rctRect.Height);

			return rctRect;
		}
	}

	public class Circle : Ellipse
	{
		public Circle(PointF pntFCenter, float flRadius)
		: base(new RectangleF(pntFCenter.X - flRadius, pntFCenter.Y - flRadius, flRadius * 2, flRadius * 2))
		{
			if (flRadius <= m_flTolerance)
			{
				throw new ArgumentOutOfRangeException("Radius", String.Format("Input radius has a value of {0}. Radius values must exceed 0.0 in length.", flRadius));
			}
		}

		public Circle(float flULPointX, float flULPointY, float flDiameter)
		: base(new RectangleF(new PointF(flULPointX, flULPointY), new SizeF(flULPointX + flDiameter, flULPointY + flDiameter)))
		{
			if (flDiameter <= m_flTolerance)
			{
				throw new ArgumentOutOfRangeException("Diameter", String.Format("Input diameter has a value of {0}. Diameter values must exceed 0.0 in length.", flDiameter));
			}
		}
	};
}
