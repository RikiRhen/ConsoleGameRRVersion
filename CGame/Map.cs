using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGame
{
    internal class Map
    {
        private Cell[,] _cells;
        public int Width { get; }
        public int Height { get; }

        public List<Creature> Creatures { get; } = new List<Creature>();

        public Map(int  width, int height)
        {
            Width = width;
            Height = height;

            _cells = new Cell[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    _cells[y, x] = new Cell(y, x);
                }
            }
        }

        internal Cell? GetCell (int y, int x)
        {
            return (x < 0 || x >= Width || y < 0 || y >= Height) ? null : _cells[y, x];
        }
    }
}
