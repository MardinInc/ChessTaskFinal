namespace FigureCore
{
    class Rook : Warp
    {
        public Rook(int newX, int newY) : base(newX, newY) { }
        public override bool TestMove(int newX, int newY)
        {
            return (x == newX || y == newY);
        }
    }
}