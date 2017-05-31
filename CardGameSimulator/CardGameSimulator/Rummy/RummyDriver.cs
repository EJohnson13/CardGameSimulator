using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Rummy
{
    class RummyDriver
    {
        public static void drive()
        {
            RummyGame game = new RummyGame();
            game.Run();
        }
    }
}
