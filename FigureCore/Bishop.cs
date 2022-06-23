using System;

namespace FigureCore
{
    class Bishop : Warp
    {
        public Bishop(int newX, int newY) : base(newX, newY) { }
        public override bool TestMove(int newX, int newY)
        {
            return (Math.Abs(x - newX) == Math.Abs(y - newY));
        }
    }
}