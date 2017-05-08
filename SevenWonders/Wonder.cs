using System;

namespace SevenWonders
{
	/// <summary>
	/// Класс "чудо света"
	/// </summary>
	public abstract class Wonder
	{
		/// <summary>
		/// Название чуда
		/// </summary>
		protected string name;
		public virtual string Name {
			get {
				return name;
			}
		}
		
		/// <summary>
		/// Место расположения
		/// </summary>
		protected string location;
		public virtual string Location {
			get {
				return location;
			}
		}
		
		/// <summary>
		/// Создатели
		/// </summary>
		protected string builders;
		public virtual string Builders {
			get {
				return builders;
			}
		}

		/// <summary>
		/// Описание
		/// </summary>
		private string description;
		public virtual string Description {
			get {
				return description;
			}
			set {
				description = value;
			}
		}

		/// <summary>
		/// Показ чуда
		/// </summary>
		public abstract void Show();

		public override string ToString()
		{
			return (string)(
			    "Name of wonder: " + Name +
			    "\nLocation: " + Location +
			    "\nBuilders: " + Builders +
			    "\nDescription: " + Description);
		}
	}
}
