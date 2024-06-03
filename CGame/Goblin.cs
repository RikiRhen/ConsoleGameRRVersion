using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGame
{
    internal class Goblin : Creature
    {
        public Goblin (Cell cell) : base (cell, " ")
        {
            Color = ConsoleColor.Red;
        }
    }
}
