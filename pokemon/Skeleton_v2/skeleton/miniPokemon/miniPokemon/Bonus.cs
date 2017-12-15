using System;
using System.Runtime.CompilerServices;

namespace miniPokemon
{
    public class Bonus
    {
        public static string Beginning()
        {
            Console.WriteLine("welcome");
            Console.WriteLine("Wanna play Epimon?");
            Console.WriteLine("1- yes    2- no");
            int a = Console.Read();
            while (a != 1 || a != 2)
            {
                Console.WriteLine("Choose 1 or 2 is that hard you dumbass?");
                a = Console.Read();          
            }
            Console.Clear();
            return a;
        }

        public static void Choose_Name(ref string s, ref string s2)
        {
            Console.WriteLine("What is your name by the way?");
            s = Console.ReadLine();
            Console.WriteLine("Oh yes I remember you now and what is the name of" +
                              "your friend?");
            s2 = Console.ReadLine();
            Console.WriteLine("Oh yes but ''PTDR T ki twa?'' ");
        }

        public static BonusPoke Acdc()
        {
            Console.WriteLine("So you chose an ACDC. Wich one would you like?");
            Console.WriteLine("1- Thomas      2-Charles");
            Console.WriteLine("3- Silvanosky  4- Tetra");
            int s = 0;
            while (s < 1 || s > 4)
            {
                Console.WriteLine("Choose between 1 and 4 is that hard you dumbass?");
                s = Console.Read();
            }
            if (s == 1)
            BonusPoke thomas = new BonusPoke("thomas" , BonusPoke.BonusType.ACDC);
            Trainer tom = new Trainer("Tom", 19);

        }
        
        
        
    }
}