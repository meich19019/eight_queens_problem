using System;
using System.Collections.Generic;
using System.Linq;

namespace eight_queens_problem
{
    public class Chessboard
    {
        public int N { get; }
        public List<Position> ChessPositions { get; }
        public List<Position> SafePositions { get; private set; }

        public Chessboard(int n)
        {
            N = n;
            ChessPositions = new List<Position>();
            SafePositions = new List<Position>();
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    SafePositions.Add(new Position(x, y));
                }
            }
        }

        public void PutChess(Chess chess)
        {
            ChessPositions.Add(chess.Position);
            List<Position> dangerousPositions = new List<Position>();
            foreach (Position safePosition in SafePositions)
            {
                bool onVerticalLine = safePosition.X == chess.Position.X;
                bool onHorizontalLine = safePosition.Y == chess.Position.Y;
                bool onCrossLine = safePosition.X - chess.Position.X == safePosition.Y - chess.Position.Y;
                if (onVerticalLine || onHorizontalLine || onCrossLine)
                {
                    dangerousPositions.Add(safePosition);
                }
            }
            SafePositions = SafePositions.Except(dangerousPositions).ToList();
        }

        public void PrintChessboard()
        {
            Dictionary<int, Dictionary<int, char>> chessMap = new Dictionary<int, Dictionary<int, char>>();
            for (int x = 0; x < N; x++)
            {
                chessMap[x] = new Dictionary<int, char>();
                for (int y = 0; y < N; y++)
                {
                    chessMap[x][y] = '.';
                }
            }
            foreach (Position chessPosition in ChessPositions)
            {
                chessMap[chessPosition.X][chessPosition.Y] = 'Q';
            }
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    Console.Write(chessMap[x][y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
