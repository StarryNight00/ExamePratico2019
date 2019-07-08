using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class Exit
    {
        internal int CoorY { get; private set; }
        internal int CoorX { get; private set; }

        Random rand = new Random();
        Board board = new Board();

        public Exit(Board board)
        {
            this.board = board;

            CoorY = rand.Next(board.Row);
            CoorX = board.Column - 1;
        }
    }
}
