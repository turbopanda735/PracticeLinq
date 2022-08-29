using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinq
{
    public static class Program
    {
        public static void Main()
        {
            var videoGameList = new List<string>()
            {
                "Pokémon Legends: Arceus", "Fall Guys", "Minecraft", "Sonic the Hedgehog 2", 
                "Halo 3", "Splitgate", "The Elder Scrolls 5: Skyrim", "Super Mario Galaxy 2",
                "Doom", "The Sims 4", "Animal Crossing: New Horizons", "Grim Fandango"
            };

            videoGameList.OrderBy(game => game.Length).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            videoGameList.OrderBy(game => game).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            videoGameList.Where(game => game.Contains("a")).OrderBy(game => game).Reverse().ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
        }
    }
}

