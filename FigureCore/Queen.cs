using System;

namespace FigureCore
{
    class Queen : Warp
    {
        public Queen(int newX, int newY) : base(newX, newY) { }
        public override bool TestMove(int newX, int newY)
        {
            return (x == newX || y == newY || Math.Abs(x - newX) == Math.Abs(y - newY));
        }
    }
}