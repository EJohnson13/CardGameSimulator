using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameSimulator
{
    public class Driver
    {
        static void Main(string[] args)
        {
            RunGames Run = new RunGames();
            Run.SelectGame();
        }
    }
}
