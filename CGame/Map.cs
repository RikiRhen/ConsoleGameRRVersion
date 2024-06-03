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

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    _cells[x, y] = new Cell(x, y);
                }
            }

            //Kapsla in arenan med väggar
            for (int y = 0; y < width; y++)
            {
                // Kolumnerna längst till vänster och höger
                Wall wall = new Wall(GetCell(0, y)!);
                Decorations.Add(wall);
                wall = new Wall(GetCell(height -1 , y)!);
                Decorations.Add(wall);
            }

            for (int x = 0; x < height; x++)
            {
                //Första och sista raden
                Wall wall = new Wall(GetCell(x, 0)!);
                Decorations.Add(wall);
                wall = new Wall(GetCell(x, width - 1)!);
                Decorations.Add(wall);
            }

            //Decorating arena
            Decorations.Add(new Stalagmite(GetCell(5, 7)!));
            Decorations.Add(new Stalactite(GetCell(4, 7)!));
            Decorations.Add(new Stalagmite(GetCell(11, 19)!));
            Decorations.Add(new Stalagmite(GetCell(15, 6)!));
            Decorations.Add(new Stalagmite(GetCell(2, 4)!));
            Decorations.Add(new Stalactite(GetCell(19, 20)!));
            Decorations.Add(new Stalagmite(GetCell(20, 20)!));

        }

        internal Cell? GetCell (int y, int x)
        {
            return (x < 0 || x >= Width || y < 0 || y >= Height) ? null : _cells[y, x];
        }
    }
}
