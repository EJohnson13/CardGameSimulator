using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace CardGameSimulator.Blackjack
{
    class BlackjackLogic
    {
        BlackjackDealer dealer = new BlackjackDealer();
        
        public void RunGame()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Welcome to Blackjack! Please select your gamemode");
                int versonSelection = PromptGameVersion();

                switch (versonSelection)
                {
                    case 1:
                        PlayPvP();
                        break;
                    case 2:
                        PlayPvC();
                        break;
                    case 3:
                        loop = false;
                        Console.WriteLine("Goodbye!");
                        break;
                }
            } while (loop);
        }

        public int PromptGameVersion()
        {
            string[] options = { "Player v Player", "Player v Computer", "Back To Main Menu" };
            int menuSelection = CIO.PromptForMenuSelection(options, false);
            return menuSelection;
        }

        public void PlayPvP()
        {
            BlackjackPlayer player1 = new BlackjackPlayer();
            BlackjackPlayer player2 = new BlackjackPlayer();
            dealer.CreateDeck();
            dealer.Shuffle();

            //1st deal
            //deal 2 cards to player1 
            Card newCard = dealer.Deal();
            player1.AddCard(newCard);
            newCard = dealer.Deal();
            player1.AddCard(newCard);
            //deal 2 cards to player2
            newCard = dealer.Deal();
            player2.AddCard(newCard);
            newCard = dealer.Deal();
            player2.AddCard(newCard);

            //show players their cards and let them choose what to do
            Console.WriteLine("Player 1's turn!");
            bool loop = true;
            int p1Total;
            do
            {
                p1Total = CountCards(player1);
                for (int i = 0; i < player1.PlayerHand.Count; i++)
                {
                    Console.WriteLine(player1.PlayerHand[i]);
                }
                Console.WriteLine("Total: " + p1Total);
                string[] options = { "Hit", "Stay" };
                int selection = CIO.PromptForMenuSelection(options, false);
                switch (selection)
                {
                    case 1:
                        Hit(player1);
                        break;
                    case 2:
                        loop = false;
                        break;
                }
                p1Total = CountCards(player1);
                if (p1Total > 21)
                {
                    Console.WriteLine("Oh no you bust!");
                    loop = false;
                }
            } while (loop);

            Console.Clear();
            Console.WriteLine("Player 2's turn!");
            loop = true;
            int p2Total;
            if (p1Total <= 21)
            {
                do
                {
                    p2Total = CountCards(player2);
                    for (int i = 0; i < player2.PlayerHand.Count; i++)
                    {
                        Console.WriteLine(player2.PlayerHand[i]);
                    }
                    Console.WriteLine("Total: " + p2Total);
                    string[] options = { "Hit", "Stay" };
                    int selection = CIO.PromptForMenuSelection(options, false);
                    switch (selection)
                    {
                        case 1:
                            Hit(player2);
                            break;
                        case 2:
                            loop = false;
                            break;
                    }
                    p2Total = CountCards(player2);
                    if (p2Total > 21)
                    {
                        Console.WriteLine("Oh no you bust!");
                        loop = false;
                    }
                } while (loop);

                //show both players totals and declare a winner
                Console.WriteLine("Player 1: " + p1Total + "\tPlayer 2: " + p2Total);
                if (p1Total > p2Total) { Console.WriteLine("Player 1 wins!!!"); }
                else if (p2Total > p1Total) { Console.WriteLine("Player 2 wins!!!"); }
                else { Console.WriteLine("Tie!!!"); }
            }
            else
            {
                Console.WriteLine("Player 1 Bust!!! Player 2 Wins!!!");
            }
        }

        public void PlayPvC()
        {

        }

        public void Hit(BlackjackPlayer player)
        {
            Card newCard = dealer.Deal();
            player.AddCard(newCard);
        }

        public int CountCards(BlackjackPlayer player)
        {
            int total = 0;
            int aceCount = 0;
            for(int i = 0; i < player.PlayerHand.Count; i++)
            {
                if(player.PlayerHand[i].value != CardEnums.Face.Ace && player.PlayerHand[i].value != CardEnums.Face.Jack && player.PlayerHand[i].value != CardEnums.Face.Queen && player.PlayerHand[i].value != CardEnums.Face.King)
                {
                    total += (int)player.PlayerHand[i].value + 1;
                }
                else if(player.PlayerHand[i].value == CardEnums.Face.Jack || player.PlayerHand[i].value == CardEnums.Face.Queen || player.PlayerHand[i].value == CardEnums.Face.King)
                {
                    total += 10;
                }
                else
                {
                    aceCount += 1;
                }
            }

            for(int i = 0; i < aceCount; i++)
            {
                if(total + 11 > 21)
                {
                    total += 1;
                }
                else
                {
                    total += 11;
                }
            }

            return total;
        }
    }
}
