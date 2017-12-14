using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer tom = new Trainer("Tête de bite", 19);
            tom.CatchAPokemon(new Pokemon("Evoli", 50, 2, Pokemon.Poketype.ELECTRICK));
            tom.CatchAPokemon(new Pokemon("Salameche", 90, 9, Pokemon.Poketype.POISON));
            int count = tom.NumberOfPokemon(); //count = 2
            tom.Birthday(); //tom.Age = 20
            tom.MyPokemon();

        }
    }
}
