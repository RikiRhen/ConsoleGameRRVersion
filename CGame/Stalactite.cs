using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGame
{
    internal class Stalactite : Decoration
    {
        public Stalactite(Cell cell) : base(cell, "▼ ")
        {
            Color = ConsoleColor.DarkGray;
        }
    }
}
