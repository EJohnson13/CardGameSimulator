using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Durak
{
    public class DurakPlayer : IPlayerable
    {
        public List<Card> playerHand { get; set; }

        public void AddCard(Card newCard)
        {
            playerHand.Add(newCard);
        }

        public Card PlayCard() { return null; }

        public List<string> DisplayHand(List<Card> hand)
        {
            List<string> handList = new List<string>();
            foreach(Card card in hand)
            {
                handList.Add(card.ToString());
            }
            return handList;
        }
    }
}
