using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class BoardRender
    {
        private Board board;
        private Player player;
        private Exit exit;

        public BoardRender(Board board, Player player, Exit exit)
        {
            this.board = board;
            this.player = player;
            this.exit = exit;
        }

        private void MapLegend()
        {
            int pX = player.CoorX;
            int pY = player.CoorY;

            int eX = exit.CoorX;
            int eY = exit.CoorY;


            Console.WriteLine($"Current coordinates P:\tx = {pX}\ty = {pY}");
            Console.WriteLine($"Current coordinates E:\tx = {eX}\ty = {eY}");
            Console.WriteLine($"Current HP:\t{player.HP}");
        }

        private void MapGrid()
        {
            for (int y = 0; y < board.Row; y++)
            {
                Console.Write("\t\t");

                for (int x = 0; x < board.Column; x++)
                {
                    if (x == player.CoorX && y == player.CoorY)
                    {
                        Console.Write(" P ");
                    }
                    else if (x == exit.CoorX && y == exit.CoorY)
                    {
                        Console.Write(" E ");
                    }
                    else
                    {
                        Console.Write(" . ");
                    }
                }

                Console.Write("\n");
            }
        }

        public void Render()
        {
            Console.Write("\n");
            MapLegend();
            MapGrid();
        }
    }
}
