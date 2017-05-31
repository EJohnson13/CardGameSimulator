using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Rummy
{
    class RummyGame
    {
        public static void Run()
        {
            bool keepgoing = true;
            RummyDealer dlr = new RummyDealer();
            List<Card> deck = dlr.CreateDeck();

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to Rummy!");
                Console.WriteLine("-----------------");
                Console.WriteLine(" ");


            } while (keepgoing);
        }
    }
}
