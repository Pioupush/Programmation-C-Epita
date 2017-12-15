using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace miniPokemon
{
    public class Pokebonus : Animal
    {
        public enum TypeBonus
        {
            ACDC,
            Effray,
            C1,
            Algo
        };

        #region Constructor

        private int life;
        private int damage;
        private TypeBonus typebonus;
        private bool isKO = false;
        private int maxlife;
        private List<Attack> ListAttack;  

        public Pokebonus(string name, int life, int maxlife, int damage, TypeBonus typebonus)
            : base(name)
        {
            this.life = life;
            this.damage = damage;
            this.typebonus = typebonus;
            this.maxlife = maxlife;
            ListAttack = new List<Attack>();
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
            Console.WriteLine(typebonus);
        }


        public int Attack()
        {
            return damage;
        }

        public void GetHurt(int damageIn)
        {
            life = life - damageIn;
            if (life < 0)
            {
                life = 0;
                IsKO = true;
            }
        }

        public void Heal(int life) 
        {
            Life = life + Life;
            if (life > maxlife)
                life = maxlife;
            if (Life > 0)
                IsKO = false;
        }
        
        public int Maxlife
        {
            get { return maxlife; }
            set { maxlife = value; }
        }


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
        

        public TypeBonus Typebonus
        {
            get { return typebonus; }
            set { typebonus = value; }
        }

        #endregion Methods
    }
}