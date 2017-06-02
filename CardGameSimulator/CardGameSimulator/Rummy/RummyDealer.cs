using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Rummy
{
    class RummyDealer : Dealer
    {
        public override List<Card> CreateDeck()
        {
         
            List<Card> deck = new List<Card>();

      
            foreach (CardEnums.Face face in Enum.GetValues(typeof(CardEnums.Face)))
                      {
                            Card card = new Card(face, CardEnums.Color.Red, CardEnums.Suit.Diamonds);
                            deck.Add(card);
                       }

            foreach (CardEnums.Face face in Enum.GetValues(typeof(CardEnums.Face)))
            {
                Card card = new Card(face, CardEnums.Color.Red, CardEnums.Suit.Hearts);
                deck.Add(card);
            }

            foreach (CardEnums.Face face in Enum.GetValues(typeof(CardEnums.Face)))
            {
                Card card = new Card(face, CardEnums.Color.Black, CardEnums.Suit.Spades);
                deck.Add(card);
            }

            foreach (CardEnums.Face face in Enum.GetValues(typeof(CardEnums.Face)))
            {
                Card card = new Card(face, CardEnums.Color.Black, CardEnums.Suit.Clubs);
                deck.Add(card);
            }

            return deck;
        }

        public List<Card> DealCards(List<RummyPlayer> players, List<Card> shuffledDeck )
        {

            foreach(RummyPlayer player in players)
            {
               for(int i = 0; i < 6; i++)
                {
                    Card card = shuffledDeck[i];
                    player.AddCard(card);
                    shuffledDeck.Remove(card);
                }
            }

            return shuffledDeck;
        }





        public List<Card> ShuffleCards(List<Card> deck)
        {
            Random rand = new Random();


            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card card = deck[k];
                deck[k] = deck[n];
                deck[n] = card;
            }

            return deck;
        }






        public override Card Deal()
        {
            throw new NotImplementedException();
        }

        public override void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
        