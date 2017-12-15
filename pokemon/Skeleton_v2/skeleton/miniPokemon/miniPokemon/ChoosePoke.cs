using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using miniPokemon;

namespace miniPokemon
{
    public class ChoosePoke
    {
        public static Pokebonus Acdc()
        {
            Console.WriteLine("So you chose an ACDC. Wich one would you like?");
            Console.WriteLine("1- Thomas      2-Charles");
            Console.WriteLine("3- Silvanosky  4- Tetra");
            int s = 0;
            s = Console.Read();
            while (s < 1 || s > 4)
            {
                Console.WriteLine("Choose between 1 and 4 is that hard you dumbass?");
                s = Console.Read();
            }
            if (s == 1)
            {
                Console.WriteLine("Oh nice choice ! Thomas Goooooo");
                return new Pokebonus("Thomas", 650, 650, 5, Pokebonus.TypeBonus.ACDC);
            }
            if (s == 2)
            {
                Console.WriteLine("Oh bad choice ! Charles Goooooo");
                return new Pokebonus("Charles", 500, 500, 2, Pokebonus.TypeBonus.ACDC);
            }
            if (s == 3)
            {
                Console.WriteLine("Oh very bad choice ! Silvanosky Goooooo");
                return new Pokebonus("Silvanosky", 600, 600, 2, Pokebonus.TypeBonus.ACDC);
            }
            if (s == 4)
            {
                Console.WriteLine("Oh very nice choice ! Tetra Goooooo");
                return new Pokebonus("Tetra", 700, 700, 5, Pokebonus.TypeBonus.ACDC);
            }
            
            throw new ArgumentException("n should be between 1 and 4, strange");
        }
        
        public static Pokebonus C1()
        {
            Console.WriteLine("So you chose a C1. Wich one would you like?");
            Console.WriteLine("1- Thomas T.   2- Justin");
            Console.WriteLine("3- Malo        4- Appoline");
            int s = 0;
            s = Console.Read();
            while (s < 1 || s > 4)
            {
                Console.WriteLine("Choose between 1 and 4 is that hard you dumbass?");
                s = Console.Read();
            }
            if (s == 1)
            {
                Console.WriteLine("Oh nice choice ! Thomas T. Goooooo");
                return new Pokebonus("Thomas T.", 12, 12, 10, Pokebonus.TypeBonus.C1);
            }
            if (s == 2)
            {
                Console.WriteLine("Oh the best choice ! Justin Goooooo");
                return new Pokebonus("Justin", 1000, 1000, 10, Pokebonus.TypeBonus.C1);
            }
            if (s == 3)
            {
                Console.WriteLine("Oh good choice ! Malo Goooooo");
                return new Pokebonus("Malo", 240, 240, 1, Pokebonus.TypeBonus.C1);
            }
            if (s == 4)
            {
                Console.WriteLine("Oh very nice choice pervert ! Appoline Goooooo");
                return new Pokebonus("Appoline", 1, 1, 0, Pokebonus.TypeBonus.C1);
            }
            
            throw new ArgumentException("n should be between 1 and 4, strange");
        }
        
        public static Pokebonus Admin()
        {
            Console.WriteLine("So you chose an Admin. Wich one would you like?");
            Console.WriteLine("1- Courtois    2- Cavatorta");
            Console.WriteLine("3- Advance     4- JPO");
            int s = 0;
            s = Console.Read();
            while (s < 1 || s > 4)
            {
                Console.WriteLine("Choose between 1 and 4 is that hard you dumbass?");
                s = Console.Read();
            }
            if (s == 1)
            {
                Console.WriteLine("Oh nice choice ! Courtois Goooooo");
                return new Pokebonus("Courtois", 500, 500, 5, Pokebonus.TypeBonus.C1);
            }
            if (s == 2)
            {
                Console.WriteLine("Oh nice choice ! Cavatorta Goooooo");
                return new Pokebonus("Cavatorta", 100, 100, 2, Pokebonus.TypeBonus.C1);
            }
            if (s == 3)
            {
                Console.WriteLine("Oh nice choice ! Advance Goooooo");
                return new Pokebonus("Advance", 240, 240, 1, Pokebonus.TypeBonus.C1);
            }
            if (s == 4)
            {
                Console.WriteLine("Oh I wouldn't have expected that but...  JPO Goooooo");
                return new Pokebonus("JPO", 1, 1, 0, Pokebonus.TypeBonus.C1);
            }
            
            throw new ArgumentException("n should be between 1 and 4, strange");
        }
        
    }
}