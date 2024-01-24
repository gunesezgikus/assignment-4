using gunes_ezgi_kus;

Game gm = new Game();

void GameStart()
{
    Console.WriteLine("1. New game");
    Console.WriteLine("2. About the author");
    Console.WriteLine("3. Exit");
    Console.Write("> ");
    string menu = Console.ReadLine();
    Console.WriteLine();
    if (menu == "1")
    {
        int totalMoves = 0;
        string[] ticTacToeBoard = new string[9];
        gm.DrawTicTacToeBoard(ticTacToeBoard);

        do
        {
            if (totalMoves != 9)
            {
                string currentPlayer;
                if (totalMoves % 2 == 0)
                {
                    currentPlayer = "X";
                }
                else
                {
                    currentPlayer = "O";
                }
                Console.Write($"{currentPlayer}'s move > ");

                int userMove = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine();
                if (userMove < 0 || ticTacToeBoard.Length <= userMove || ticTacToeBoard[userMove] == "X" || ticTacToeBoard[userMove] == "O")
                {
                    Console.WriteLine("Illegal move! Try again.");
                }
                else
                {
                    ticTacToeBoard[userMove] = currentPlayer;
                    totalMoves++;
                    gm.DrawTicTacToeBoard(ticTacToeBoard);

                    if (gm.CheckForWinner(ticTacToeBoard, currentPlayer))
                    {
                        Console.WriteLine($"\n{currentPlayer} won!");
                        Console.Write("[Press Enter to return to main menu...]");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else
            {
                totalMoves++;
                Console.WriteLine("Game over!");
            }
        } while (totalMoves < 10);
        GameStart();
    }
    else if (menu == "2")
    {
        Console.WriteLine("Gunes Ezgi Kus");
        Console.Write("[Press Enter to return to main menu...]");
        Console.ReadLine();
        GameStart();
    }
    else if (menu == "3")
    {
        Console.WriteLine("Are you sure you want to quit? [y/n]");
        Console.Write("> ");
        string temp = Console.ReadLine();
        if (temp.ToLower() != "y") GameStart();
    }
    else
    {
        Console.WriteLine();
        GameStart();
    }
}

GameStart();
