using System;

namespace Complex
{
	/// <summary>
	/// Description of cmplx.
	/// </summary>
	public class cmplx
	{
		public double X { get; set; }
		public double Y { get; set; }
		public cmplx(double X, double Y)
		{
			this.X=X;
			this.Y=Y;
		}
		public static cmplx operator*(cmplx left, cmplx right)
		{
			return new cmplx(left.X * right.X - left.Y * right.Y,
			                 left.Y * right.X + left.X * right.Y);
		}
		public static cmplx operator/(cmplx left, cmplx right)
		{
			return new cmplx(
				(left.X * right.X + left.Y * right.Y) / (right.X * right.X + right.Y * right.Y),
				(left.Y * right.X - left.X * right.Y) / (right.X * right.X + right.Y * right.Y));
		}
		public override string ToString()
		{
			return string.Format("{0:###.##}" + (Y < 0 ? "-" : "") + "{1:###.##}i", X, Y);
		}
	}
}
