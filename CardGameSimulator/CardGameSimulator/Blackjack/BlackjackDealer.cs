using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameSimulator.CardEnums;

namespace CardGameSimulator.Blackjack 
{
    public class BlackjackDealer : Dealer
    {
        private List<Card> Deck = new List<Card>();

        public override List<Card> CreateDeck()
        {
            for(int color = 0; color < 2; color++)
            {
                for(int suit = 0; suit < 4; suit++)
                {
                    for(int face = 0; face < 13; face++)
                    {
                        Card newCard = new Card((Face)face, (Color)color, (Suit)suit);
                        Deck.Add(newCard);
                    }
                }
            }
            return Deck;
        }

        public override Card Deal()
        {
            Card dealtCard = Deck[0];
            Deck.Remove(dealtCard);
            return dealtCard;
        }

        public override void Shuffle()
        {
            int spot = 0;
            Card temp;
            Random randy = new Random();

            for(int i = Deck.Count -1; i > 0; i--)
            {
                spot = randy.Next(1, i + 1);
                temp = Deck[spot];
                Deck[spot] = Deck[i];
                Deck[i] = temp;
            }
        }
    }
}
