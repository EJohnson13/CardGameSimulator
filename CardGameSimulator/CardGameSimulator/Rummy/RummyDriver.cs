﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator.Rummy
{
    class RummyDriver
    {
        public void Drive()
        {
            RummyGame game = new RummyGame();
            game.Run();
        }
    }
}
