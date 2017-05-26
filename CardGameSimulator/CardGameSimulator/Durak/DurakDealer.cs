using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameSimulator.CardEnums;

namespace CardGameSimulator.Durak
{
    public class DurakDealer : Dealer
    {
        public override List<Card> CreateDeck()
        {
            List<Card> deck = new List<Card>();
            deck.Add(new Card());
            return null;
        }

        public override Card Deal()
        {
            return null;
        }

        public override void Shuffle()
        {
            
        }
    }
}
