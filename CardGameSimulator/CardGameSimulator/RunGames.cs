using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace CardGameSimulator
{
    public class RunGames
    {
        public void SelectGame()
        {
            string[] options = { "Blackjack", "Durak", "Rummy", "War" };
            bool loop = true;

            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t\t\tWelcome to Card Game Simulator");
            Console.WriteLine("\t\t\t\t\t------------------------------");
            Console.WriteLine(" ");
            
            do
            {
                Console.WriteLine("What game would you like to play?");
                Console.WriteLine("---------------------------------");
                int menuSelection = CIO.PromptForMenuSelection(options, true);
                switch (menuSelection)
                {
                    case 1:
                        //Run Blackjack
                        break;
                    case 2:
                        //run Durak
                        break;
                    case 3:
                        //run rummy

                        Rummy.RummyDriver rumDriver = new Rummy.RummyDriver();
                        rumDriver.Drive();

                        break;
                    case 4:
                        //run war
                        break;
                    case 0:
                        Console.WriteLine("Thanks for playing!");
                        loop = false;
                        break;
                }
            } while (loop);
        }
    }
}
