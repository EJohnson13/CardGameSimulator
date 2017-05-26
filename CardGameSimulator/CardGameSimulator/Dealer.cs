using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator
{
    public abstract class Dealer
    {
        private List<Card> Deck;

        abstract public List<Card> CreateDeck();
        abstract public void Shuffle();
        abstract public Card Deal();
    }
}
