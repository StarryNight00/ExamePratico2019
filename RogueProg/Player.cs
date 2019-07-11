using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    /// <summary>
    /// Class that controls all of the player's capacities.
    /// Controls the player's movement and other command calls.
    /// </summary>
    class Player
    {
        /// <summary>
        /// Property to get the Y axis coordinate for the player.
        /// Self-implemented Property with a private set to protect this value.
        /// </summary>
        internal int CoorY { get; private set; }

        /// <summary>
        /// Property to get the X axis coordinate for the player.
        /// Self-implemented Property with a private set to protect this value.
        /// </summary>
        internal int CoorX { get; private set; }

        /// <summary>
        /// Property to set the health value for the player.
        /// Self-implemented Property with a private set to protect this value.
        /// </summary>
        internal int HP { get; private set; }

        //Variable that keeps track of the Key input.
        private ConsoleKey moveKey;

        //Boolean variable that activates the 'Look Around' map render.
        internal bool lookAround;

        //Initializes a random numer generator.
        private Random rand = new Random();

        //Initializes the game board. It's function is mainly to make sure
        //all random variables are kept within the same number interval.
        private Board board = new Board();

        /// <summary>
        /// Player constructor.
        /// Resets the initial values, such as HP and base coordinates.
        /// </summary>
        /// <param name="board">Game board variable from Board class.</param>
        public Player(Board board)
        {
            this.board = board;

            HP = 100;

            CoorY = rand.Next(board.Row);
            CoorX = 0;

            lookAround = false;
        }
        
        /// <summary>
        /// Movement controller. Changes the player's coordinates.
        /// Keeps track of any other control key activated by the player.
        /// </summary>
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
