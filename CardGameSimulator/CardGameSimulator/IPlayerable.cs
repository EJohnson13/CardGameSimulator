using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator
{
    public interface IPlayerable
    {
        List<Card> playerHand { get; set; }
        Card PlayCard();
        void AddCard(Card newCard);
       
    }
}
