using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class Game
    {
        //Call game realted variables and methods
        //Controls gameloop

        Board board = new Board();

        internal void GameInit()
        {
            board.GetArgs();
            int column = board.Column;
            int row = board.Row;

            Console.WriteLine($"rows {row} : columns {column}");
            Console.Read();
        }
        
    }
}
