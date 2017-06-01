using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Rummy
{
    class RummyPlayer : IPlayerable
    {
        private string name = "Player";
        public List<Card> playerHand { get; set; }

        public RummyPlayer(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) name = "Default Name";

            this.name = name;
        }

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
