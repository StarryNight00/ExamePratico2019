using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    /// <summary>
    /// Class that creates the Exit.
    /// </summary>
    class Exit
    {
        /// <summary>
        /// Property to get the Y axis coordinate for the exit.
        /// Self-implemented Property with a private set to protect this value.
        /// </summary>
        internal int CoorY { get; private set; }

        /// <summary>
        /// Property to get the X axis coordinate for the exit.
        /// Self-implemented Property with a private set to protect this value.
        /// </summary>
        internal int CoorX { get; private set; }

        private Random rand = new Random();
        private Board board = new Board();

        /// <summary>
        /// Exit constructor. Resets the base coordinates.
        /// </summary>
        /// <param name="board">Game board variable from Board class.</param>
        public Exit(Board board)
        {
            this.board = board;

            CoorY = rand.Next(board.Row);
            CoorX = board.Column - 1;
        }
    }
}
