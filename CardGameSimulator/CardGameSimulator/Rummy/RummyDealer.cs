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

            foreach (CardEnums.Color color in Enum.GetValues(typeof(CardEnums.Color)))
            {
                foreach(CardEnums.Suit suit in Enum.GetValues(typeof(CardEnums.Suit)))
                {
                    foreach  (CardEnums.Face face in Enum.GetValues(typeof(CardEnums.Face)))
                    {
                        Card card = new Card(face, color, suit);
                        deck.Add(card);
                    }
                }
            }

            return deck;
        }

        public void DealCards(List<RummyPlayer> players, List<Card> shuffledDeck )
        {

            foreach(RummyPlayer player in players)
            {
               
            }

        }





        public List<Card> ShuffleCards(List<Card> unShuffledDeck)
        {
            Random rand = new Random();
            List<Card> shuffledDeck = new List<Card>();
            Card[] unShuffed = unShuffledDeck.ToArray();
            int ran = 0;

            for (int i = 0; i < unShuffed.Length; i++)
            {
                ran = rand.Next(i, unShuffed.Length + 1);
                Card card = unShuffed[ran];
                shuffledDeck.Add(card);
            }
            
            return shuffledDeck;
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
        