using System;

namespace SevenWonders
{
    /// <summary>
    /// Description of Wonder.
    /// </summary>
    public abstract class Wonder
    {
        protected string name;
        public virtual string Name
        {
            get
            {
                return name;
            }
        }

        protected string location;
        public virtual string Location
        {
            get
            {
                return location;
            }
        }

        protected string builders;
        public virtual string Builders
        {
            get
            {
                return builders;
            }
        }

        private string description;
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public abstract void Show();

        public virtual string ToString()
        {
            return (string)(
                "Name of wonder: " + Name +
                "\nLocation: " + Location +
                "\nBuilders: " + Builders +
                "\nDescription: " + Description);
        }
    }
}