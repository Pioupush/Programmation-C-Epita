using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Threading;
using miniPokemon;

namespace miniPokemon
{
    public class Bonus
    {
        public static int Beginning()
        {
            Console.WriteLine("welcome");
            Console.WriteLine("Wanna play Epimon?");
            Console.WriteLine("1- yes    2- no");
            int a = Console.Read();
            a = Console.Read();    
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
            Thread.Sleep(3000);
            Console.WriteLine("I'm joking lets begin !");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static int Choose_class(string s)
        {
            Console.WriteLine("OK wich class would you like your pokemon to be?");
            Console.WriteLine("1- ACDC    2- Admin");
            Console.WriteLine("3- C1      4- ");
            int a = Console.Read();
            a = Console.Read();
            while (a < 1 || a > 4 )
            {
                Console.WriteLine("Choose between 1 and 4 is that hard you dumbass?");
                a = Console.Read();    
            }
            Console.Clear();
            return a;
        }
        
        
        
    }
}