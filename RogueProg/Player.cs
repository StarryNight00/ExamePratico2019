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

        internal bool lookAround;

        Random rand = new Random();
        Board board = new Board();

        public Player(Board board)
        {
            this.board = board;

            HP = 100;

            CoorY = rand.Next(board.Row);
            CoorX = 0;

            lookAround = false;
        }
        
        public void MovePlayer()
        {
            Console.WriteLine("\n\nWhat would you like to do?");
            Console.Write("> ");

            Console.WriteLine(moveKey = Console.ReadKey().Key);
            switch (moveKey)
            {
                case ConsoleKey.NumPad8:
                    if (CoorY < 1)
                    {
                        Console.WriteLine("\n\n>> CAN'T GO THAT WAY...");
                    }
                    else
                    {
                        //up
                        CoorY = CoorY - 1;
                        HP--;
                        turn++;
                    }
                    
                    break;

                case ConsoleKey.NumPad2:
                    if (CoorY >= board.Row - 1)
                    {
                        Console.WriteLine("\n\n>> CAN'T GO THAT WAY...");
                    }
                    else
                    {
                        //down
                        CoorY = CoorY + 1;
                        HP--;
                        turn++;
                    }
                    
                    break;
                case ConsoleKey.NumPad4:
                    if (CoorX < 1)
                    {
                        Console.WriteLine("\n\n>> CAN'T GO THAT WAY...");
                    }
                    else
                    {
                        //left
                        CoorX = CoorX - 1;
                        HP--;
                        turn++;
                    }
                    break;
                case ConsoleKey.NumPad6:
                    if (CoorX >= board.Column - 1)
                    {
                        Console.WriteLine("\n\n>> CAN'T GO THAT WAY...");
                    }
                    else
                    {
                        //right
                        CoorX = CoorX + 1;
                        HP--;
                        turn++;
                    }
                    break;
                case ConsoleKey.NumPad7:
                    if (CoorX < 1 || CoorY < 1)
                    {
                        Console.WriteLine("\n\n>> CAN'T GO THAT WAY...");
                    }
                    else
                    {
                        //diag upLeft
                        CoorY = CoorY - 1;
                        CoorX = CoorX - 1;

                        HP--;
                        turn++;
                    }
                    break;
                case ConsoleKey.NumPad9:
                    if (CoorX >= board.Column - 1 || CoorY < 1)
                    {
                        Console.WriteLine("\n\n>> CAN'T GO THAT WAY...");
                    }
                    else
                    {
                        //diag upRight
                        CoorY = CoorY - 1;
                        CoorX = CoorX + 1;

                        HP--;
                        turn++;
                    }
                    break;
                case ConsoleKey.NumPad3:
                    if (CoorX >= board.Column - 1 || CoorY >= board.Row - 1)
                    {
                        Console.WriteLine("\n\n>> CAN'T GO THAT WAY...");
                    }
                    else
                    {
                        //diag downRight
                        CoorY = CoorY + 1;
                        CoorX = CoorX + 1;

                        HP--;
                        turn++;
                    }
                    break;
                case ConsoleKey.NumPad1:
                    if (CoorX < 1 || CoorY >= board.Row - 1)
                    {
                        Console.WriteLine("\n\n>> CAN'T GO THAT WAY...");
                    }
                    else
                    {
                        //diag downLeft
                        CoorY = CoorY + 1;
                        CoorX = CoorX - 1;

                        HP--;
                        turn++;
                    }
                    break;
                case ConsoleKey.L:
                    Console.WriteLine("\n\n>> LOOKING AROUND...");
                    lookAround = true;
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\n\n>> INVALID COMMAND");
                    break;
            }
        }

    }
}
