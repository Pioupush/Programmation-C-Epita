using System;
using System.Collections.Generic;
using System.Reflection;

namespace miniPokemon
{
    public class Animal
    {
        #region Constructor

        private string name;
        
        public Animal(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion Constructor
        
        #region Methods

        public virtual void WhoAmI()
        {
            Console.WriteLine("i am bidule");
        }

        public virtual void Describe()
        {
            Console.WriteLine("machin avec plein de plus" +name);
        }

        public void Rename(string NewName)
        {
            name = NewName;
        }

        #endregion Methods
        
    }
}
