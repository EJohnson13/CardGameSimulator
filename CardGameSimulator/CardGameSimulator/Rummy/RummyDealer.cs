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
            // Make an array out of all the card Enums
            // Make a for loop adding to the list of all the made cards

          

            foreach (CardEnums.Color color in Enum.GetValues(typeof(CardEnums.Color)))
            {
                foreach(CardEnums.Suit suit in Enum.GetValues(typeof(CardEnums.Suit)))
                {
                    foreach  (CardEnums.Face face in Enum.GetValues(typeof(CardEnums.Face)))
                    {
                        Card card = new Card(face, color, suit);
                    }
                }
            }




            throw new NotImplementedException();
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
        