using System;

namespace FigureCore
{
    public class WarpCreate
    {
        static public Warp Create(string pieceCode, int x, int y)
        {
            Warp example;

            switch (pieceCode)
            {
                case "KING":
                case "K":
                case "♔":
                    example = new King(x, y);
                    break;

                case "QUEEN":
                case "Q":
                case "♕":
                    example = new Queen(x, y);
                    break;

                case "BISHOP":
                case "B":
                case "♗":
                    example = new Bishop(x, y);
                    break;

                case "ROOK":
                case "R":
                case "♖":
                    example = new Rook(x, y);
                    break;

                case "KNIGHT":
                case "N":
                case "♘":
                    example = new Knight(x, y);
                    break;

                default: throw (new Exception("Bad piece OR Bad location!"));
            }

            return example;
        }

        static public Warp Create(int pieceCode, int x, int y)
        {
            return Create(pieceCode.ToString(), x, y);
        }
    }
}
