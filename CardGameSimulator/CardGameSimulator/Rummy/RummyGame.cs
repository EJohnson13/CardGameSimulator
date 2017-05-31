using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Rummy
{
    class RummyGame
    {
        public void Run()
        {
            bool keepgoing = true;
            
            Console.WriteLine(" ");
            Console.WriteLine("Welcome to Rummy!");
            Console.WriteLine("-----------------");

            do
            {
                
                Console.WriteLine(" ");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1) Play Rummy");
                Console.WriteLine("2) Exit");

                string input = Console.ReadLine();

                if (input.Equals("1"))
                {
                    Rummy();
                    keepgoing = true;
                }
                else if (input.Equals("2"))
                {
                    Console.WriteLine("Good Bye!");
                    keepgoing = false;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Please enter valid input");
                    Console.WriteLine(" ");
                    keepgoing = true;
                }


            } while (keepgoing);
        }



        public void Rummy()
        {
            RummyDealer dlr = new RummyDealer();
            List<Card> deck = dlr.CreateDeck();


            foreach(Card card in deck)
            {
                Console.WriteLine(card);
            }


        }

        public bool CheckForMatches(List<Card> hand)
        {


            return false;
        }

        public bool CheckForRun(List<Card> hand)
        {

            return false;
        }
    }
}
