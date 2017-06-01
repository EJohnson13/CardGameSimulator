using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameSimulator.CardEnums;


namespace CardGameSimulator.Durak
{
    public class DurakDealer : Dealer
    {
        public List<Card> deck = new List<Card>();
        public override List<Card> CreateDeck()
        {
            List<Card> deck = new List<Card>();
            deck.Add(new Card(Face.Six, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.Six, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.Six, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.Six, Color.Black, Suit.Spades));
            deck.Add(new Card(Face.Seven, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.Seven, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.Seven, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.Seven, Color.Black, Suit.Spades));
            deck.Add(new Card(Face.Eight, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.Eight, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.Eight, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.Eight, Color.Black, Suit.Spades));
            deck.Add(new Card(Face.Nine, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.Nine, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.Nine, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.Nine, Color.Black, Suit.Spades));
            deck.Add(new Card(Face.Ten, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.Ten, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.Ten, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.Ten, Color.Black, Suit.Spades));
            deck.Add(new Card(Face.Jack, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.Jack, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.Jack, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.Jack, Color.Black, Suit.Spades));
            deck.Add(new Card(Face.Queen, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.Queen, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.Queen, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.Queen, Color.Black, Suit.Spades));
            deck.Add(new Card(Face.King, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.King, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.King, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.King, Color.Black, Suit.Spades));
            deck.Add(new Card(Face.Ace, Color.Red, Suit.Hearts));
            deck.Add(new Card(Face.Ace, Color.Red, Suit.Diamonds));
            deck.Add(new Card(Face.Ace, Color.Black, Suit.Clubs));
            deck.Add(new Card(Face.Ace, Color.Black, Suit.Spades));

            return deck;
        }

        public override Card Deal()
        {
            if(deck.Count > 0)
            {
                Card drawn = deck[0];
                deck.Remove(deck[0]);
                return drawn;
            }
            else
            {
                return null;
            }
        }

        public override void Shuffle()
        {
            Random rand = new Random();
            for(int i = 0; i<deck.Count; i++)
            {
                int randomIndex = rand.Next(deck.Count);
                int randomIndex2 = rand.Next(deck.Count);
                Card savedOffCard = deck[randomIndex];
                deck[randomIndex] = deck[randomIndex2];
                deck[randomIndex2] = savedOffCard;
            }
        }
    }
}
