using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGame
{
    internal class Creature : IDrawable
    {
        public Cell Cell { get; set; }
        public string Symbol { get; }
        public ConsoleColor Color { get; protected set; } = ConsoleColor.White;
        
        public Creature(Cell cell, string symbol)
        {
            Cell = cell ?? throw new ArgumentNullException(nameof(cell));
            if (string.IsNullOrEmpty(symbol))
            {
                throw new ArgumentException($"'{nameof(symbol)}' cannot be null or empty.", nameof(symbol));
            }

            Symbol = symbol;
        }
    }
}
