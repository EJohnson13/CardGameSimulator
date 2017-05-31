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
            do
            {
                int menuSelection = CIO.PromptForMenuSelection(options, true);
                switch (menuSelection)
                {
                    case 1:
                        Blackjack.BlackjackLogic run = new Blackjack.BlackjackLogic();
                        run.RunGame();
                        break;
                    case 2:
                        //run Durak
                        break;
                    case 3:
                        //run rummy
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
