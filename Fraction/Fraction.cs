using System;

namespace Fract
{
	/// <summary>
	/// Класс реализует простую дробь и операции для работы с ней
	/// </summary>
	public class Fraction
	{
		/// <summary>
		/// Числитель 
		/// </summary>
		public int Numerator {
			private set;
			get;
		}
		/// <summary>
		/// Знаменатель
		/// </summary>
		public int Denumerator {
			private set;
			get;
		}
		
		public Fraction(int Numerator, int Denumerator)
		{
			this.Numerator = Numerator;
			this.Denumerator = Denumerator;
		}
		
		public Fraction(double num)
		{
			string buf = num.ToString();
			int length = buf.Length - buf.IndexOfAny(",.".ToCharArray()) - 1;
			while (true) {
				try {
					Denumerator = (int)Math.Pow(10, length);
					Numerator = (int)(num * Denumerator);
					break;
				} catch (OverflowException) {
					--length;
				}
			}
			this.Reduce();
		}
		
		/// <summary>
		/// Возвращает найбольший общий делитель двух чисел
		/// </summary>
		public static int NOD(int n, int m)
		{
			return m == 0 ? n : NOD(m, n % m);
		}
		
		/// <summary>
		/// Возвращает найбольший общий делитель элементов дроби
		/// </summary>
		public int NOD()
		{
			return NOD(Numerator, Denumerator);
		}
		
		/// <summary>
		/// Возвращает найменьшее общее кратное двух чисел
		/// </summary>
		public static int NOK(int n, int m)
		{
			try {
				return n * m / NOD(n, m);
			} catch (OverflowException) {
				return 0;
			}
		}
		
		/// <summary>
		/// Возвращает найменьшее общее кратное элементов дроби
		/// </summary>
		public int NOK()
		{
			return NOK(Numerator, Denumerator);
		}
		
		/// <summary>
		/// Сокращает дробь
		/// </summary>
		public Fraction Reduce()
		{
			int nod = NOD(Numerator, Denumerator);
			Numerator /= nod;
			Denumerator /= nod;
			return this;
		}
		
		/// <summary>
		/// Возвращает обратную дробь
		/// </summary>
		public Fraction Reverse()
		{
			return new Fraction(this.Denumerator, this.Numerator);
		}
		
		public static implicit operator Fraction(double num)
		{
			return new Fraction(num);
		}
		
		public static implicit operator int(Fraction fr)
		{
			return (int)fr.Numerator / fr.Denumerator;
		}
		
		public static implicit operator Fraction(int num)
		{
			return new Fraction(num);
		}
		
		public static implicit operator double(Fraction fr)
		{
			return (double)fr.Numerator / fr.Denumerator;
		}
		
		#region Mathematic operators
		public static Fraction operator*(Fraction left, Fraction right)
		{
			return new Fraction(left.Numerator * right.Numerator,
			                    left.Denumerator * right.Denumerator);
		}
		
		public static Fraction operator/(Fraction left, Fraction right)
		{
			return left * right.Reverse();
		}
		
		public static Fraction operator+(Fraction left, Fraction right)
		{
			int nok = Fraction.NOK(left.Denumerator, right.Denumerator);
			return new Fraction(left.Numerator * nok / left.Denumerator	+
								right.Numerator * nok / right.Denumerator,
								nok);
		}
		
		public static Fraction operator-(Fraction left)
		{
			return new Fraction(-left.Numerator, left.Denumerator);
		}
		
		public static Fraction operator-(Fraction left, Fraction right)
		{
			return left + (-right);
		}
		#endregion
		
		#region Logic operators
		public static bool operator true(Fraction obj)
		{
			if (obj == null)
				return false;
			return Math.Abs(obj.Numerator) < obj.Denumerator;
		}
		
		public static bool operator false(Fraction obj)
		{
			if (obj == null)
				return false;
			return Math.Abs(obj.Numerator) >= obj.Denumerator;
		}
		
		public static Fraction operator !(Fraction obj)
		{
			return -obj;
		}
		
		public static bool operator >(Fraction left, Fraction right)
		{
			return (double)left > (double)right;
		}
		
		public static bool operator <(Fraction left, Fraction right)
		{
			return (double)left < (double)right;
		}
		
		public static bool operator ==(Fraction lhs, Fraction rhs)
		{
			if (ReferenceEquals(lhs, rhs))
				return true;
			if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
				return false;
			return lhs.Equals(rhs);
		}

		public static bool operator !=(Fraction lhs, Fraction rhs)
		{
			return !(lhs == rhs);
		}
		#endregion
		
		#region Equals and GetHashCode implementation
		public override bool Equals(object obj)
		{
			Fraction other = obj as Fraction;
			if (other == null)
				return false;
			return this.Numerator == other.Numerator && this.Denumerator == other.Denumerator;
		}

		public override int GetHashCode()
		{
			return Numerator.GetHashCode() ^ Denumerator.GetHashCode();
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("{0}/{1}", Numerator, Denumerator);
		}
	}
}
