using System;
using System.Runtime.CompilerServices;

namespace miniPokemon
{
    public class Attack
    {
        #region Constructor
        
        //attribute
        private string name;
        private int speed;
        private int damage;
        private string description;
        private BonusPoke.BonusType type;
        
        //getter & setter
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Attack(string name, int damage, int speed, 
            BonusPoke.BonusType type, string description)
        {
            this.name = name;
            this.damage = damage;
            this.speed = speed;
            this.description = description;
            this.type = type;
        }
        
        #endregion Constructor
        
        #region Methods

        public virtual void Name()
        {
            Console.WriteLine(name);
        }

        public virtual BonusPoke.BonusType Type()
        {
            return type;
        }

        public virtual void Describe()
        {
            Console.WriteLine(description);
        }


        public virtual int Damage()
        {
            return damage;
        }

        public virtual void ChangeSpeed(int pourcent)
        {
            Speed = Speed * pourcent;
        }


        #endregion Methods
    }
}