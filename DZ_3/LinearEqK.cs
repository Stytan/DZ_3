using System;

namespace Equation
{
	/// <summary>
	/// Структура линейного уравнения вида ax+by+c=0
	/// </summary>
	public struct LinearEqK : IEquatable<LinearEqK>
	{
		public int A, B, C;

		public LinearEqK(int A = 0, int B = 0, int C = 0)
		{
			this.A = A;
			this.B = B;
			this.C = C;
		}

		/// <summary>
		/// Преобразует строку в экземпляр уравнения 
		/// </summary>
		/// <param name="str">Строка с коэффициентами разделенными пробелом</param>
		/// <returns>Возвращает экземпляр линейного уравнения</returns>
		public static LinearEqK Parse(string str)
		{
			str.Trim();
			string[] tmp = str.Split(' ');
			if (tmp.Length != 3)
				throw new FormatException("Not the correct string format");
			return new LinearEqK(Convert.ToInt32(tmp[0]), Convert.ToInt32(tmp[1]), Convert.ToInt32(tmp[2]));
		}
		
		/// <summary>
		/// Возвращает решение системы двух уравнений
		/// </summary>
		public static void Solution(LinearEqK L1, LinearEqK L2, out float X, out float Y)
		{
			double D = L1.A * L2.B - L1.B * L2.A;
			if (Math.Abs(D) < 0.001)
				throw new ArgumentOutOfRangeException(
					"The system of equations has no solutions or has infinitely many solutions");
			double D1 = L1.C * L2.B - L1.B * L2.C;
			X = (float)(D1 / D);
			double D2 = L1.A * L2.C - L1.C * L2.A;
			Y = (float)(D2 / D);
		}

		/// <summary>
		/// Выводит в консоль решение системы уравнений
		/// </summary>
		public static void WriteSolution(LinearEqK L1, LinearEqK L2)
		{
			float X, Y;
			Console.WriteLine("The system of equations");
			Console.WriteLine(L1.ToString());
			Console.WriteLine(L2.ToString());
			try {
				LinearEqK.Solution(L1, L2, out X, out Y);
				Console.WriteLine("has the following solutions: x=" + X + ", y=" + Y);
			} catch (ArgumentOutOfRangeException) {
				Console.WriteLine("has no solutions");
			}
		}

		public override string ToString()
		{
			return (string)(A.ToString() + "x" + (B < 0 ? " " : " +") + B + "y = " + C);
		}

		#region Equals and GetHashCode implementation
		public override bool Equals(object obj)
		{
			if (obj is LinearEqK)
				return Equals((LinearEqK)obj);
			else
				return false;
		}

		public bool Equals(LinearEqK other)
		{
			return (this.A == other.A) && (this.B == other.B);
		}

		public override int GetHashCode()
		{
			return A.GetHashCode() ^ B.GetHashCode();
		}

		public static bool operator ==(LinearEqK left, LinearEqK right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(LinearEqK left, LinearEqK right)
		{
			return !left.Equals(right);
		}
		#endregion
	}
}
