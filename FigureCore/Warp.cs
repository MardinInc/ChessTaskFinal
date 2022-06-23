namespace FigureCore
{
    public abstract class Warp
    {
        protected int x;
        protected int y;

        public Warp(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
        public abstract bool TestMove(int newX, int newY);

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }
    }
}