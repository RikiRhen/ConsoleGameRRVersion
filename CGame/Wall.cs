using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGame
{
    internal class Wall : Decoration

    {
        public Wall(Cell cell) : base(cell, "■ ")
        {
            Color = ConsoleColor.White;
        }
    }
}
