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

        private string move;

        //private ConsoleKey move;

        internal int turn = 1;

        Random rand = new Random();
        Board board = new Board();

        public Player(Board board)
        {
            this.board = board;

            HP = 10;

            CoorY = rand.Next(board.Row);
            CoorX = 0;
        }
        
        public void MovePlayer()
        {
            Console.WriteLine("\n\nWhich direction do you want to move?");
            Console.Write("> ");
            Console.WriteLine(move = Console.ReadLine());


            //Project movement conditions
            if (move == "up")
            {
                CoorY = CoorY - 1;

                HP--;
                turn++;
            }
            else if (move == "down")
            {
                CoorY = CoorY + 1;

                HP--;
                turn++;
            }
            else if (move == "left")
            {
                CoorX = CoorX - 1;

                HP--;
                turn++;
            }
            else if (move == "right")
            {
                CoorX = CoorX + 1;

                HP--;
                turn++;
            }
            else if (move == "up right")
            {
                CoorY = CoorY - 1;
                CoorX = CoorX + 1;

                HP--;
                turn++;
            }
            else if (move == "down right")
            {
                CoorY = CoorY + 1;
                CoorX = CoorX + 1;

                HP--;
                turn++;
            }
            else if (move == "up left")
            {
                CoorY = CoorY - 1;
                CoorX = CoorX - 1;

                HP--;
                turn++;
            }
            else if (move == "down left")
            {
                CoorY = CoorY + 1;
                CoorX = CoorX - 1;

                HP--;
                turn++;
            }
            else if (move == "l" || move == "L")
            {
                Console.WriteLine("Look Around");
            }
            else if (move == "q" || move == "Q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("invalid command");
            }


            //NumPad movement conditions
            /*Console.WriteLine(move = (ConsoleKey)Console.Read());
            switch (move)
            {
                case ConsoleKey.NumPad8:
                    //up
                    CoorY = CoorY - 1;
                    break;

                case ConsoleKey.NumPad2:
                    //down
                    CoorY = CoorY + 1;
                    break;
                case ConsoleKey.NumPad4:
                    //left
                    CoorX = CoorX - 1;
                    break;
                case ConsoleKey.NumPad6:
                    //right
                    CoorX = CoorX + 1;
                    break;
                case ConsoleKey.NumPad7:
                    //diag upLeft
                    CoorY = CoorY - 1;
                    break;

                case ConsoleKey.NumPad9:
                    //diag upRight
                    CoorY = CoorY + 1;
                    break;
                case ConsoleKey.NumPad3:
                    //diag downRight
                    CoorX = CoorX - 1;
                    break;
                case ConsoleKey.NumPad1:
                    //diag downLeft
                    CoorX = CoorX + 1;
                    break;
            }*/
        }

    }
}
