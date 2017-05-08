using System;

namespace Complex
{
	public class cmplx
	{
		public double X { get; set; }
		public double Y { get; set; }
		public cmplx(double X, double Y)
		{
			this.X=X;
			this.Y=Y;
		}
		
		#region operator*
		public static cmplx operator*(cmplx left, cmplx right)
		{
			return new cmplx(left.X * right.X - left.Y * right.Y,
				left.Y * right.X + left.X * right.Y);
		}
		public static cmplx operator*(cmplx left, double right)
		{
			return new cmplx(left.X * right, left.Y * right);
		}
		public static cmplx operator*(double left, cmplx right)
		{
			return right * left;
		}
		#endregion
		
		#region operator/
		public static cmplx operator/(cmplx left, cmplx right)
		{
			return new cmplx(
				(left.X * right.X + left.Y * right.Y) / (right.X * right.X + right.Y * right.Y),
				(left.Y * right.X - left.X * right.Y) / (right.X * right.X + right.Y * right.Y));
		}
		public static cmplx operator/(cmplx left, double right)
		{
			return new cmplx(left.X / right, left.Y / right);
		}
		public static cmplx operator/(double left, cmplx right)
		{
			return new cmplx(left / right.X, left / right.Y);
		}
		#endregion
		
		#region operator+
		public static cmplx operator+(cmplx left, cmplx right)
		{
			return new cmplx(left.X + right.X, left.Y + right.Y);
		}
		public static cmplx operator+(cmplx left, double right)
		{
			return new cmplx(left.X + right, left.Y);
		}
		public static cmplx operator+(double left, cmplx right)
		{
			return right + left;
		}
		#endregion
		
		#region operator-
		public static cmplx operator-(cmplx left, cmplx right)
		{
			return new cmplx(left.X - right.X, left.Y - right.Y);
		}
		public static cmplx operator-(cmplx left, double right)
		{
			return new cmplx(left.X - right, left.Y);
		}
		public static cmplx operator-(double left, cmplx right)
		{
			return new cmplx(left - right.X, right.Y);
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("{0:##0.##}" + (Y < 0 ? "" : "+") + "{1:##0.##}i", X, Y);
		}
	}
}
