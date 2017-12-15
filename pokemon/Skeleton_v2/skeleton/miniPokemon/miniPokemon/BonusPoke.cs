using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace miniPokemon
{
    class BonusPoke : Animal
    {

        public enum BonusType
        {
            ACDC,
            C1,
            Algo,
            Archi
        };

        
        #region Constructor
        
        //attributes
        private List<Attack> listAttack;
        private BonusType type;
        
        //get & set

        
        
        public BonusPoke(string name, BonusType type)
        : base(name)
        {

            listAttack = new List<Attack>();
            this.type = type;
        }
        
        #endregion Constructor
        
        #region Methods
        
        public List<Attack> AddAttacks(Attack a)
        {
            while (listAttack.Count < 5)
            {
                if(a.Type() == type)
                    listAttack.Add(a);
                else
                    Console.WriteLine("Choose an attack of type "+type);
                 
                
            }
            return listAttack;
        }
        
        
        
        #endregion Methods
    }
}