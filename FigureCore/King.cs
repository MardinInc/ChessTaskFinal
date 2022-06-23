using System;

namespace FigureCore
{
    class King : Warp
    {
        public King(int newX, int newY) : base(newX, newY)  { }
        public override bool TestMove(int newX, int newY)
        {
            return (Math.Abs(x - newX) <= 1 && Math.Abs(y - newY) <= 1);
        }

    }
}