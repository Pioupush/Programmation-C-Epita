using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;

namespace miniPokemon
{
    class Trainer : Animal
    {
        #region Constructor

        //attribute
        private int age;
        private List<Pokemon> listPokemon;
        
        //getter & setter
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        //constructor
        public Trainer(string name, int age)
        : base(name)
        {
            this.age = age;
            listPokemon = new List<Pokemon>();
        }

        #endregion Constructor



        #region Methods

        public override void WhoAmI()
        {
            Console.WriteLine("I'm a pokemon Trainer !");
        }

        public int NumberOfPokemon()
        {
            return listPokemon.Count;
        }

        public override void Describe()
        {
            Console.Write("My name is " +Name);
            Console.Write(" I'm " + age);
            Console.Write(" and I have ");
            Console.Write(+(NumberOfPokemon()));
            Console.WriteLine(" Pokemon !");
        }

        public void Birthday()
        {
            ++age;
        }

        public void MyPokemon()
        {
            Console.WriteLine("My pokemon are :");
            foreach(Pokemon p in listPokemon)
                Console.WriteLine("-" + p.Name);
        }

        public void CatchAPokemon(Pokemon pokemon)
        {
            listPokemon.Add(pokemon);
        }
        
        #endregion Methods
    }
}
