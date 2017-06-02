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
            RummyDealer dlr = new RummyDealer();
            List<Card> deck = dlr.CreateDeck();
            string input = null;
            int numOfPlayers = 0;


            Console.WriteLine(" ");
            Console.WriteLine("Welcome to Rummy!");
            Console.WriteLine("-----------------");
            Console.WriteLine(" ");
            Console.WriteLine("Max Players: 6");
            Console.WriteLine("Min Players: 2");
            Console.WriteLine(" ");

            while(keepgoing)
            {
                Console.WriteLine(" ");
                Console.Write("How many Players are there: ");
        
                input = Console.ReadLine();
                int.TryParse(input, out numOfPlayers);

                if(numOfPlayers > 6 || numOfPlayers < 2)
                {
                    Console.WriteLine("Please enter a valid number of players");
                    keepgoing = true;
                }
                else
                {
                    keepgoing = false;
                }

            }

            PrintDeck(deck);

            List<RummyPlayer> players = generatePlayers(numOfPlayers);
            deck = dlr.ShuffleCards(deck);

            PrintDeck(deck);
            
        }
        


        public void PrintDeck(List<Card> deck)
        {
            int counter = 0;
            foreach (Card card in deck)
            {
                counter++;
                Console.WriteLine(card +" Card #: "+ counter);
            }
            Console.WriteLine("");
        }



        public List<RummyPlayer> generatePlayers(int numberOfPlayers)
        {

            List<RummyPlayer> players = new List<RummyPlayer>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                int counter = i + 1;
                Console.Write("Player " + counter + " name: ");
                string name = Console.ReadLine();
                RummyPlayer player = new RummyPlayer(name);
                players.Add(player);
            }

            return players;
        }


        

        public void Turn(RummyPlayer player)
        {

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
