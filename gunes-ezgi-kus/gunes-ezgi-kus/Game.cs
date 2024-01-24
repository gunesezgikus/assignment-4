using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunes_ezgi_kus
{
    public class Game
    {
        public void DrawTicTacToeBoard(string[] gameBoard)
        {
            int cellIndex = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 1; col <= 11; col++)
                {
                    if (col % 4 == 0)
                    {
                        Console.Write("|");
                    }
                    else if (col % 2 == 0)
                    {
                        if (gameBoard[cellIndex] == "X" || gameBoard[cellIndex] == "O")
                        {
                            Console.Write(gameBoard[cellIndex]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        cellIndex++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (row < 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("---+---+---");
                }
            }
            Console.WriteLine();
        }

        public bool CheckForWinner(string[] gameBoard, string player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i * 3] == player && gameBoard[i * 3 + 1] == player && gameBoard[i * 3 + 2] == player
                    || gameBoard[i] == player && gameBoard[i + 3] == player && gameBoard[i + 6] == player)
                    return true;
            }
            if (gameBoard[0] == player && gameBoard[4] == player && gameBoard[8] == player || gameBoard[2] == player && gameBoard[4] == player && gameBoard[6] == player)
                return true;
            return false;
        }

    }
}
