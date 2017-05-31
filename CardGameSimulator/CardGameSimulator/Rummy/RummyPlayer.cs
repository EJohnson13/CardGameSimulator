using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Rummy
{
    class RummyPlayer : IPlayerable
    {
        public List<Card> playerHand { get ; set; }

        public void AddCard(Card newCard)
        {
            throw new NotImplementedException();
        }

        public Card PlayCard()
        {
            throw new NotImplementedException();
        }
    }
}
