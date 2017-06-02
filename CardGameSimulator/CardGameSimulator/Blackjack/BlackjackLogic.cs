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
                Console.WriteLine("\nWelcome to Blackjack! Please select your gamemode");
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
                        Console.WriteLine("\nGoodbye!");
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
            Console.WriteLine("\nPlayer 1's turn!");
            bool loop = true;
            int p1Total = CountCards(player1);
            do
            {
                Console.WriteLine("\nPlayer 2's card \n" + player2.PlayerHand[0] + "\n \nYour cards");
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
                        Console.WriteLine("\nThe dealer gave you a " + player1.PlayerHand.Last());
                        break;
                    case 2:
                        loop = false;
                        break;
                }
                p1Total = CountCards(player1);
                if (p1Total > 21)
                {
                    Console.WriteLine("\nOh no you bust!");
                    loop = false;
                }
            } while (loop);

            Console.Clear();
            Console.WriteLine("\nPlayer 2's turn!");
            loop = true;
            int p2Total = CountCards(player2);
            if (p1Total <= 21)
            {
                do
                {
                    Console.WriteLine("\nPlayer 1's card \n" + player1.PlayerHand[0] + "\n \nYour cards");
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
                            Console.WriteLine("\nThe dealer gave you a " + player1.PlayerHand.Last());
                            break;
                        case 2:
                            loop = false;
                            break;
                    }
                    p2Total = CountCards(player2);
                    if (p2Total > 21)
                    {
                        Console.WriteLine("\nOh no you bust!");
                        loop = false;
                    }
                } while (loop);

                //show both players totals and declare a winner
                Console.WriteLine("\nPlayer 1: " + p1Total + "\tPlayer 2: " + p2Total);
                if (p1Total > 21 && p2Total <= 21) { Console.WriteLine("Player 2 Wins!"); }
                else if (p2Total > 21 && p1Total <= 21) { Console.WriteLine("Player 1 Wins!"); }
                else if (p1Total > p2Total) { Console.WriteLine("Player 1 wins!"); }
                else if (p2Total > p1Total) { Console.WriteLine("Player 2 wins!"); }
                else if (p2Total > 21 && p1Total > 21) { Console.WriteLine("You both bust! No one wins!"); }
                else
                {
                    string winner = TieBreaker(player1, player2, "Player 1", "Player 2");
                    Console.WriteLine(winner + " wins!");
                }                
            }
            else
            {
                Console.WriteLine("\nPlayer 1 Bust!!! Player 2 Wins!!!");
            }
        }

        public void PlayPvC()
        {
            BlackjackPlayer player1 = new BlackjackPlayer();
            BlackjackPlayer comp1 = new BlackjackPlayer();
            dealer.CreateDeck();
            dealer.Shuffle();

            //1st deal
            //deal 2 cards to player1 
            Card newCard = dealer.Deal();
            player1.AddCard(newCard);
            newCard = dealer.Deal();
            player1.AddCard(newCard);
            //deal 2 cards to computer
            newCard = dealer.Deal();
            comp1.AddCard(newCard);
            newCard = dealer.Deal();
            comp1.AddCard(newCard);

            //show players their cards and let them choose what to do
            Console.WriteLine("\nPlayer's turn!");
            bool loop = true;
            int p1Total;
            do
            {
                Console.WriteLine("\nComputer's card \n" + comp1.PlayerHand[0] + "\n \nYour cards");
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
                        Console.WriteLine("\nThe dealer gave you a " + player1.PlayerHand.Last());
                        break;
                    case 2:
                        loop = false;
                        break;
                }
                p1Total = CountCards(player1);
                if (p1Total > 21)
                {
                    Console.WriteLine("\nOh no you bust!");
                    loop = false;
                }
            } while (loop);

            //let computer go
            loop = true;
            int compTotal = CountCards(comp1);
            if (p1Total <= 21)
            {
                Console.WriteLine("\nComputer's turn!!!");
                do
                {
                    compTotal = CountCards(comp1);

                    if (compTotal <= 17)
                    {
                        Console.WriteLine("\nThe computer hit!");
                        Hit(comp1);
                    }
                    else
                    {
                        Console.WriteLine("\nThe computer stayed!");
                        loop = false;
                    }

                } while (loop);
            }
            //show both players totals and declare a winner
            Console.WriteLine("Player 1: " + p1Total + "\tComputer: " + compTotal);
            if (p1Total > 21 && compTotal <= 21) { Console.WriteLine("Computer Wins!"); }
            else if (compTotal > 21 && p1Total <= 21) { Console.WriteLine("Player 1 Wins!"); }
            else if (p1Total > compTotal) { Console.WriteLine("Player 1 wins!"); }
            else if (compTotal > p1Total) { Console.WriteLine("Computer wins!"); }
            else if (compTotal > 21 && p1Total > 21) { Console.WriteLine("You both bust! No one wins!"); }
            else
            {
                string winner = TieBreaker(player1, comp1, "Player", "Computer");
                Console.WriteLine(winner + " wins!");
            }
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

        public string TieBreaker(BlackjackPlayer player1, BlackjackPlayer player2, string p1Name, string p2Name)
        {
            int p1Highest = 0;
            int p1CardNum = 0;
            int p2Highest = 0;
            int p2CardNum = 0;
            string winner = "";

            for(int i = 0; i < player1.PlayerHand.Count; i++)
            {
                if((int)(player1.PlayerHand[i].value) * 10 > p1Highest)
                {
                    p1Highest = (int)(player1.PlayerHand[i].value) * 10;
                    p1CardNum = i;
                }
            }
            for (int i = 0; i < player2.PlayerHand.Count; i++)
            {
                if ((int)(player2.PlayerHand[i].value) * 10 > p2Highest)
                {
                    p2Highest = (int)(player2.PlayerHand[i].value) * 10;
                    p2CardNum = i;
                }
            }

            if(p1Highest > p2Highest) { winner = p1Name; }
            else if (p2Highest > p1Highest) { winner = p2Name; }
            else
            {
               if((int)(player1.PlayerHand[p1CardNum].suit) < (int)(player2.PlayerHand[p2CardNum].suit)) { winner = p1Name; }
                else { winner = p2Name; }
            }

            return winner;
        }
    }
}
