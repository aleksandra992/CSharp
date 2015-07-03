using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minite
    {
       static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] gameBoard = CreateGameBoard();
            char[,] bombs = PutBombs();
            int scoreCounter = 0;
            //TODO:da vidam so e grum
            bool isDead = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool isStartOfTheGame = true;
            const int maxScore = 35;
            bool isWinnerWithoutStepOnBomb = false;

            do
            {
                if (isStartOfTheGame)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    PrintBoard(gameBoard);
                    isStartOfTheGame = false;
                }
                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= gameBoard.GetLength(0) && column <= gameBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        GetClassification(champions);
                        break;
                    case "restart":
                        gameBoard = CreateGameBoard();
                        bombs = PutBombs();
                        PrintBoard(gameBoard);
                        isDead = false;
                        isStartOfTheGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                ShowBoardValues(gameBoard, bombs, row, column);
                                scoreCounter++;
                            }
                            if (maxScore == scoreCounter)
                            {
                                isWinnerWithoutStepOnBomb = true;
                            }
                            else
                            {
                                PrintBoard(gameBoard);
                            }
                        }
                        else
                        {
                            isDead = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }
                if (isDead)
                {
                    PrintBoard(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", scoreCounter);
                    string nickname = Console.ReadLine();
                    Score t = new Score(nickname, scoreCounter);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].PlayerScore < t.PlayerScore)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Score r1, Score r2) => r2.PlayerName.CompareTo(r1.PlayerName));
                    champions.Sort((Score r1, Score r2) => r2.PlayerScore.CompareTo(r1.PlayerScore));
                    GetClassification(champions);

                    gameBoard = CreateGameBoard();
                    bombs = PutBombs();
                    scoreCounter = 0;
                    isDead = false;
                    isStartOfTheGame = true;
                }
                if (isWinnerWithoutStepOnBomb)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    PrintBoard(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Score to4kii = new Score(imeee, scoreCounter);
                    champions.Add(to4kii);
                    GetClassification(champions);
                    gameBoard = CreateGameBoard();
                    bombs = PutBombs();
                    scoreCounter = 0;
                    isWinnerWithoutStepOnBomb = false;
                    isStartOfTheGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void GetClassification(List<Score> scores)
        {
            Console.WriteLine("\nTo4KI:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, scores[i].PlayerName, scores[i].PlayerScore);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }
       
        private static void ShowBoardValues(char[,] board,
            char[,] mines, int row, int column)
        {
            char minesCount = CountMines(mines, row, column);
            mines[row, column] = minesCount;
            board[row, column] = minesCount;
        }

        private static void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutBombs()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] gameBoard = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int nextRandom = random.Next(50);
                if (!mines.Contains(nextRandom))
                {
                    mines.Add(nextRandom);
                }
            }

            foreach (int mine in mines)
            {
                int mineColumn = (mine / boardColumns);
                int mineRow = (mine % boardColumns);
                if (mineRow == 0 && mine != 0)
                {
                    mineColumn--;
                    mineRow = boardColumns;
                }
                else
                {
                    mineRow++;
                }
                gameBoard[mineColumn, mineRow - 1] = '*';
            }

            return gameBoard;
        }

        private static void CalculateBoardValues(char[,] board)
        {
            int column = board.GetLength(0);
            int row = board.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char count = CountMines(board, i, j);
                        board[i, j] = count;
                    }
                }
            }
        }

        private static char CountMines(char[,] board, int row, int column)
        {
            int counter = 0;
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, column] == '*')
                {
                    counter++;
                }
            }
            if (row + 1 < rows)
            {
                if (board[row + 1, column] == '*')
                {
                    counter++;
                }
            }
            if (column - 1 >= 0)
            {
                if (board[row, column - 1] == '*')
                {
                    counter++;
                }
            }
            if (column + 1 < columns)
            {
                if (board[row, column + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (board[row - 1, column - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (board[row - 1, column + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (board[row + 1, column - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (board[row + 1, column + 1] == '*')
                {
                    counter++;
                }
            }
            return char.Parse(counter.ToString());
        }
    }
}