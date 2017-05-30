using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameSimulator.CardEnums;

namespace CardGameSimulator
{
    public class Card
    {
        public readonly Face value;
        public readonly Color color;
        public readonly Suit suit;

        public Card(Face Value, Color Color, Suit Suit)
        {
            value = Value;
            color = Color;
            suit = Suit;
        }

        public override string ToString()
        {
            return $"{value} of {suit} ({color})";
        }
    }
}
