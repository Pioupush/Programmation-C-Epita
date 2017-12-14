using System;
using System.Collections.Generic;
using System.Reflection;

namespace miniPokemon
{
    public class Pokemon : Animal
    {
        public enum Poketype
        {
            POISON,
            FIRE,
            WATER,
            GRASS,
            ELECTRICK
        };

        #region Constructor

        private int life;
        private int damage;
        private Poketype poketype;
        private int level = 1;
        private bool isKO = false;

        public int Life
        {
            get { return life; }
            set { life = value; }
        }

        public bool IsKO
        {
            get { return isKO; }
            set { isKO = value; }
        }


        public Pokemon(string name, int life, int damage, Poketype poketype)
            : base(name)
        {
            this.life = life;
            this.damage = damage;
            this.poketype = poketype;
        }

        #endregion Constructor


        #region Methods

        public override void WhoAmI()
        {
            Console.WriteLine("I'm a Pokemon");
        }

        public override void Describe()
        {
            Console.Write("My name is " + Name + " I'm a Pokemon of type ");
            Console.WriteLine(poketype + " and I'm level " + level);
        }

        public void LevelUp()
        {
            ++level;
        }

        public int Attack()
        {
            Console.WriteLine(Name + " uses cut, it's super effective");
            return damage;
        }

        public void GetHurt(int damage)
        {
            life = life - damage;
            if (life < 0)
            {
                life = 0;
                isKO = true;
            }
        }

        public void Heal(int life) 
        {
            Life = life + Life;
            if (Life > 0)
                isKO = false;
        }

        #endregion Methods
    }
}
