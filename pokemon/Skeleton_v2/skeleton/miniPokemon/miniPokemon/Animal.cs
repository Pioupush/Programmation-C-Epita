using System;
using System.Collections.Generic;
using System.Reflection;

namespace miniPokemon
{
    public class Animal
    {
        #region Constructor

        //attribute
        private string name;

        //getter & setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal(string name)
        {
            this.name = name;
        }

        #endregion Constructor

        #region Methods

        public virtual void WhoAmI()
        {
            Console.WriteLine("I am an amimal !");
        }

        public virtual void Describe()
        {
            Console.WriteLine("My name is " + Name + ".");
        }

        public void Rename(string NewName)
        {
            Name = NewName;
        }

        #endregion Methods
    }
}
