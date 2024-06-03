using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGame
{
    internal interface IDrawable
    {
        ConsoleColor Color { get; }
        string Symbol { get; }
    }
}
