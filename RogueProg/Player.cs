using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class Player
    {
        internal int CoorY { get; private set; }
        internal int CoorX { get; private set; }
        internal int HP { get; private set; }

        //private string move;

        private ConsoleKey moveKey;

        internal int turn = 1;

        Random rand = new Random();
        Board board = new Board();

        public Player(Board board)
        {
            this.board = board;

            HP = 100;

            CoorY = rand.Next(board.Row);
            CoorX = 0;
        }
        
        public void MovePlayer()
        {
            Console.WriteLine("\n\nWhat would you like to do?");
            Console.Write("> ");

            Console.WriteLine(moveKey = Console.ReadKey().Key);
            switch (moveKey)
            {
                case ConsoleKey.NumPad8:
                    //up
                    CoorY = CoorY - 1;
                    HP--;
                    turn++;
                    break;

                case ConsoleKey.NumPad2:
                    //down
                    CoorY = CoorY + 1;
                    HP--;
                    turn++;
                    break;
                case ConsoleKey.NumPad4:
                    //left
                    CoorX = CoorX - 1;
                    HP--;
                    turn++;
                    break;
                case ConsoleKey.NumPad6:
                    //right
                    CoorX = CoorX + 1;
                    HP--;
                    turn++;
                    break;
                case ConsoleKey.NumPad7:
                    //diag upLeft
                    CoorY = CoorY - 1;
                    CoorX = CoorX - 1;

                    HP--;
                    turn++;
                    break;

                case ConsoleKey.NumPad9:
                    //diag upRight
                    CoorY = CoorY - 1;
                    CoorX = CoorX + 1;

                    HP--;
                    turn++;
                    break;
                case ConsoleKey.NumPad3:
                    //diag downRight
                    CoorY = CoorY + 1;
                    CoorX = CoorX + 1;

                    HP--;
                    turn++;
                    break;
                case ConsoleKey.NumPad1:
                    //diag downLeft
                    CoorY = CoorY + 1;
                    CoorX = CoorX - 1;

                    HP--;
                    turn++;
                    break;
                case ConsoleKey.L:
                    Console.WriteLine("Look Around");
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("INVALID COMMAND");
                    break;
            }
        }

    }
}
