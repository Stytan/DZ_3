using System;

namespace Population
{
	/// <summary>
	/// Description of City.
	/// </summary>
	public abstract class City
	{
		protected string name;
		public string Name { get { return name; } }
		protected string country;
		public string Country { get { return country; } }
		protected int population;
		public int Population { get { return population; } }
		public override string ToString()
		{
			return string.Format("City {0} in {1}, population: {2:N0}", Name, Country, Population);
		}
		public static bool operator>(City city1, City city2)
		{
			return city1.Population > city2.Population;
		}
		public static bool operator<(City city1, City city2)
		{
			return city1.Population < city2.Population;
		}
		public static bool operator>=(City city1, City city2)
		{
			return city1.Population >= city2.Population;
		}
		public static bool operator<=(City city1, City city2)
		{
			return city1.Population <= city2.Population;
		}
		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			var city = obj as City;
			if (city == null)
				return false;
			return ((this.Name == city.Name)
			&& (this.Country == city.Country)
			&& (this.Population == city.Population));
		}
		public override int GetHashCode()
		{
			return (Country.GetHashCode() ^ Name.GetHashCode() ^ Population);
		}
		public static bool operator==(City city1, City city2)
		{
			return city1.Equals(city2);
		}
		public static bool operator!=(City city1, City city2)
		{
			return !city1.Equals(city2);
		}
	}
}
