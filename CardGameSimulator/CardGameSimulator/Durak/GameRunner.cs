using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Durak
{
    public class GameRunner
    {
        public DurakLogic durak = new DurakLogic();
        public DurakDealer dealer = new DurakDealer();
        public DurakPlayer player1 = new DurakPlayer();
        public DurakPlayer player2 = new DurakPlayer();
        public bool p1Att = true;
        public bool defPass;
        public bool noHand = false;

        public void ConfirmPlay()
        {

        }

        public void Run()
        {
            // Creating the deck
            dealer.deck = dealer.CreateDeck();
            // Shuffling the deck
            dealer.Shuffle();
            // Getting Players' hands
            GetStartHand(player1);
            GetStartHand(player2);
            // Finding Trump Suit
            GetTrump();
            // Bout 1
            defPass = durak.Bout(player1, player2);
            // All subsequent Bouts
            do
            {
                // Checking for who was the attacker
                if (p1Att == true)
                {
                    
                }
                else if ( p1Att == false)
                {

                }
                
                CheckLoss(player1, player2);
            } while (!noHand);
        }

        public void GetTrump()
        {
            Card trumpCard = dealer.Deal();
            durak.FindTrump(trumpCard);
            durak.DisplayTrump();
            dealer.deck.Insert(-1, trumpCard);
        }

        public void GetStartHand(DurakPlayer player)
        {
            for (int i = 0; i < 7; i++)
            {
                player.playerHand.Add(dealer.Deal());
            }
        }

        public void CheckLoss(DurakPlayer p1, DurakPlayer p2)
        {
            if (p1.playerHand.Count == 0)
            {
                Console.WriteLine("Player 2 has lost.");
                noHand = true;
            }
            else if (p2.playerHand.Count == 0)
            {
                Console.WriteLine("Player 1 has lost.");
                noHand = true;
            }
            else noHand = false;
        }

        public void RestockHand(DurakPlayer player1, DurakPlayer player2)
        {
            for (int i = 0;i<durak.wave;i++)
            {
                Card restock = dealer.Deal();
                player1.AddCard(restock);
            }
            if (defPass)
            {
                for (int i = 0; i < durak.wave; i++)
                {
                    Card restock = dealer.Deal();
                    player1.AddCard(restock);
                }
            }
        }

        public bool CheckDefenderPlay()
        {

            return defPass;
        }
    }
}
