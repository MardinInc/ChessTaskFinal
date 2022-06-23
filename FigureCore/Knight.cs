using System;

namespace FigureCore
{
    class Knight : Warp
    {
        public Knight(int newX, int newY) : base(newX, newY) { }
        public override bool TestMove(int newX, int newY)
        {
            return (Math.Abs(x - newX) == 2 && Math.Abs(y - newY) == 1 || Math.Abs(x - newX) == 1 && Math.Abs(y - newY) == 2);
        }
    }
}