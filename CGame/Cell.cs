namespace CGame
//Alt. symboler: ■ ◘ █ ▲ ◄ × ‼ Þ ○ x ♣ . Walls = ■, Player = ☻, Enemy = ‼, Corpse = ×, Lever = Þ, Gate/Door = ◘
{
    public class Cell : IDrawable
    {
        public string Symbol => ". ";
        public ConsoleColor Color { get; }
        public int Y { get; }
        public int X { get; }

        public Cell(int y, int x)
        {
            Color = ConsoleColor.White;
            Y = y;
            X = x;
        }
    }
}