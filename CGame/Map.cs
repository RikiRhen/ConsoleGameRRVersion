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
        public List<Decoration> Decorations { get; } = new List<Decoration>();

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

            //Kapsla in arenan med väggar
            for (int y = 0; y < width; y++)
            {
                // Kolumnerna längst till vänster och höger
                Wall wall = new Wall(GetCell(y, 0)!);
                Decorations.Add(wall);
                wall = new Wall(GetCell(y, height-1)!);
                Decorations.Add(wall);
            }

            for (int x = 0; x < height; x++)
            {
                //Första och sista raden
                Wall wall = new Wall(GetCell(0, x)!);
                Decorations.Add(wall);
                wall = new Wall(GetCell(height-1, x)!);
                Decorations.Add(wall);
            }

        }

        internal Cell? GetCell (int y, int x)
        {
            return (x < 0 || x >= Width || y < 0 || y >= Height) ? null : _cells[y, x];
        }
    }
}
