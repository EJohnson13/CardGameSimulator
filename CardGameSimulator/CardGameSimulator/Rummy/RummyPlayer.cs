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
        public List<Card> phand = new List<Card>();
        List<Card> IPlayerable.playerHand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RummyPlayer(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) name = "Default Name";

            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void AddCard(Card newCard)
        {
            phand.Add(newCard);
        }

        public Card PlayCard()
        {
            throw new NotImplementedException();
        }

        public void PrintPlayerHand()
        {
            foreach(Card card in phand)
            {
                Console.WriteLine(card);
            }
        }
    }
}
