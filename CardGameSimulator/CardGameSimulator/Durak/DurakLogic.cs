using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameSimulator.CardEnums;

namespace CardGameSimulator.Durak
{
    public class DurakLogic
    {
        public static Suit trump;
        public DurakPlayer player1;
        public DurakPlayer player2;
        public Card[,] playfield = new Card[6, 2];

        public static void Attack()
        {

        }
        public static void Defend()
        {

        }
        public static bool CheckDefense(Card attack, Card defense)
        {
            return true;
        }
    }
}
