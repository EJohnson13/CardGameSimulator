using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Durak
{
    public class DurakPlayer : IPlayerable
    {
        public List<Card> playerHand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddCard(Card newCard){}

        public Card PlayCard() { return null; }

    }
}
