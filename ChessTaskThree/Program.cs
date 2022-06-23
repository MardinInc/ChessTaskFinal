using System;
using System.Collections.Generic;
using FigureCore;

namespace ChessTaskThree
{
    class Program
    {
        static void Main()
        {
            var precedence = new Dictionary<string, int>() { { "A", 1 }, { "B", 2 }, { "C", 3 }, { "D", 4 }, 
                                                             { "E", 5 }, { "F", 6 }, { "G", 7 }, { "H", 8 },
                                                             { "1", 1 }, { "2", 2 }, { "3", 3 }, { "4", 4 },
                                                             { "5", 5 }, { "6", 6 }, { "7", 7 }, { "8", 8 }};
            
            // DATA INPUT
            string figure = Console.ReadLine().ToUpper();
            var x1 = precedence[Console.ReadLine().ToUpper()];
            int y1 = Convert.ToInt32(Console.ReadLine());
            var x2 = precedence[Console.ReadLine().ToUpper()];
            int y2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Warp piece = WarpCreate.Create(figure, x1, y1);
                Console.WriteLine(piece.Move(x2, y2) ? "YES" : "NO");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}