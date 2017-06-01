using System;
using CardGameSimulator.CardEnums;


namespace CardGameSimulator.Durak
{
    public class DurakLogic
    {
        public Suit trump;
        public Card[] playfield = new Card[12];
        public int wave = 1;

        public Card Attack(DurakPlayer att, int wave)
        {
            Console.Clear();
            
                return null;
        }
        public bool Defend(DurakPlayer def, Card beat)
        {
            Console.Clear();
           
            return false;
        }
        public bool Bout(DurakPlayer att, DurakPlayer def)
        {
            bool quit = false;
            bool victory = true;
            do
            {
                Console.Clear();
                Card beat = Attack(att, wave);
                if (beat == null) quit = true;
                else
                {
                    victory = Defend(def, beat);
                }
                

            } while (!quit || wave < 6 || wave < def.playerHand.Count);
            
            return victory;
        }
        public bool CheckDefense(Card attack, Card defense)
        {
            return true;
        }
        public void PrintField()
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(playfield[i].ToString());
            }
        }
        public void FindTrump(Card trumpCard)
        {
            trump = trumpCard.suit;
        }
        public void DisplayTrump()
        {
            Console.WriteLine(trump.ToString());
        }
    }
}
