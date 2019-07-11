using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    /// <summary>
    /// Class that controls the size of the game's board.
    /// </summary>
    class Board
    {
        /// <summary>
        /// Property to set the Y size of the game's board.
        /// Self-implemented Property with a private set to protect this value.
        /// </summary>
        internal int Row { get; private set; }

        /// <summary>
        /// Property to set the X size of the game's board.
        /// Self-implemented Property with a private set to protect this value.
        /// </summary>
        internal int Column { get; private set; }

        /// <summary>
        /// Property to set the difficulty of the game.
        /// Self-implemented Property with a private set to protect this value.
        /// </summary>
        internal int d;

        private int[,] grid;

        /// <summary>
        /// Board constructor. Array int with the given Column x Row dimentions.
        /// </summary>
        public Board()
        {
            grid = new int[Row, Column];
        }

        /// <summary>
        /// Function that reads the args string from the bash console and
        /// transfers the values.
        /// </summary>
        internal void GetArgs()
        {
            //String array that receives the arguments in main
            string[] values = Program.arguments;

            for (int i = 0; i < values.Length; i++)
            {
                switch (values[i])
                {
                    case "-r":
                        Row = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-c":
                        Column = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-d":
                        d = Convert.ToInt32(values[i + 1]);
                        break;
                }
            }
        }
    }
}
