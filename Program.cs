using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {

            static int GetAliveNeighBours(int x, int y, char[,] board)
            {
                int liveNeighBours = 0;
                int xLength = board.GetLength(0);
                int yLength = board.GetLength(1);
                if (x - 1 >= 0 && y - 1 >= 0 && board[x - 1, y - 1] == '1')
                {
                    ++liveNeighBours;
                }
                if (x - 1 >= 0 && board[x - 1, y] == '1')
                {
                    ++liveNeighBours;
                }
                if (x - 1 >= 0 && y + 1 < yLength && board[x - 1, y + 1] == '1')
                {
                    ++liveNeighBours;
                }
                if (y + 1 < yLength && board[x, y + 1] == '1')
                {
                    ++liveNeighBours;
                }
                if (x + 1 < xLength && y + 1 < yLength && board[x + 1, y + 1] == '1')
                {
                    ++liveNeighBours;
                }
                if (x + 1 < xLength && board[x + 1, y] == '1')
                {
                    ++liveNeighBours;
                }
                if (x + 1 < xLength && y - 1 >= 0 && board[x + 1, y - 1] == '1')
                {
                    ++liveNeighBours;
                }
                if (y - 1 >= 0 && board[x, y - 1] == '1')
                {
                    ++liveNeighBours;
                }
                return liveNeighBours;
            }

            Func<Task4, char[,]>TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                char[,] board = task.Board;
                int xLength = board.GetLength(0);
                int yLength = board.GetLength(1);
                char[,] updatedBoard = new char[xLength, yLength];
                int liveNeighBours = 0;
                for (int x = 0; x < xLength; x++)
                {
                    for (int y = 0; y < yLength; y++)
                    {
                        liveNeighBours = GetAliveNeighBours(x, y, board);

                        if (liveNeighBours < 2 || liveNeighBours > 3)
                        {
                            updatedBoard[x, y] = '0';
                        }
                        else if (liveNeighBours == 3)
                        {
                            updatedBoard[x, y] = '1';
                        }
                        else
                        {
                            updatedBoard[x, y] = board[x, y];
                        }
                    }
                }
                    
                return updatedBoard;
            };

            Task4.CheckSolver(TaskSolver);
        }
    }
}
