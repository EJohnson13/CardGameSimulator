using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Blackjack
{
    class BlackjackPlayer : IPlayerable
    {
        public List<Card> playerHand { get; set; }

        public void AddCard(Card newCard)
        {
            playerHand.Add(newCard);
        }

        public Card PlayCard()
        {
            throw new NotImplementedException();
        }
    }
}
