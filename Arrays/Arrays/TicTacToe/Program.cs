using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello! First player, do you want to be an O or an X?");
                char player1 = Convert.ToChar(Console.ReadLine());

                char player2;
                if (player1 == Convert.ToChar("O"))
                {
                    player2 = Convert.ToChar("X");
                }
                else
                {
                    player2 = Convert.ToChar("O");
                }

                InitBoard();
                
                int row;
                int col;
                DisplayBoard();

                    do
                    {

                        Console.WriteLine("Player1, choose your location (row, column): ");
                        int[] location = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        row = location[0];
                        col = location[1];
                        board[row, col] = player1;
                        DisplayBoard();
                        
                        if (CheckBoard() == false)
                        {
                            break;
                        }

                        Console.WriteLine("Player2, choose your location (row, column): ");
                        location = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                        row = location[0];
                        col = location[1];
                        board[row, col] = player2;
                        DisplayBoard();
                        CheckBoard();
                        if (CheckBoard() == false)
                        {
                            break;

                        }
                    } while (true);

            Console.WriteLine("It is a Tie!");
            Console.ReadLine();


        }

        static bool CheckBoard()
        {
            bool value = false;
            for (var r = 0; r <= 2; r++)
            {
                for (var c = 0; c <= 2; c++)
                    if (board[r, c] == ' ')
                    {
                        value = true;
                    }
                    else
                    {
                        value = false;
                    }
            }

            return value;
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
        
    }
}
