using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Rummy
{
    class RummyGame : IPlayerable
    {
        public List<Card> playerHand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
