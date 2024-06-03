
namespace CGame;
internal class Player : Creature
{
    public Player(Cell cell) : base(cell, "☻ ")
    {
        Color = ConsoleColor.Green;
    }
}