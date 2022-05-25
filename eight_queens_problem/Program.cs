using System;

namespace eight_queens_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard chessboard = new Chessboard(4);
            chessboard.PrintChessboard();
            chessboard.PutChess(new Chess(new Position(2, 3)));
            chessboard.PrintChessboard();
            foreach (Position safePosition in chessboard.SafePositions)
            {
                Console.WriteLine(safePosition.X + ", " + safePosition.Y);
            }
            chessboard.PutChess(new Chess(new Position(3, 1)));
            chessboard.PrintChessboard();
            foreach (Position safePosition in chessboard.SafePositions)
            {
                Console.WriteLine(safePosition.X + ", " + safePosition.Y);
            }
            chessboard.PutChess(new Chess(new Position(1, 0)));
            chessboard.PrintChessboard();
            foreach (Position safePosition in chessboard.SafePositions)
            {
                Console.WriteLine(safePosition.X + ", " + safePosition.Y);
            }
            chessboard.PutChess(new Chess(new Position(0, 2)));
            chessboard.PrintChessboard();
        }
    }
}
