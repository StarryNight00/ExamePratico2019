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

        internal int level = 1;

        public BoardRender(Board board, Player player, Exit exit)
        {
            this.board = board;
            this.player = player;
            this.exit = exit;
        }

        private void LevelLegend()
        {
            string leg1 = $"Level: {level} |";
            string leg2 = $" Dificulty: {board.d} |";
            string leg3 = $" Map Size: {board.Column}x{board.Row}" +
                $"";

            Console.WriteLine("\n>>> " + leg1 + leg2 + leg3 + "<<<\n\n");
        }

        private void ControlLegend()
        {
            string setas1 = "\n\t\u2196 \u2191 \u2197";
            string setas2 = "\t\u2190 \u263C \u2192";
            string setas3 = "\t\u2199 \u2193 \u2198";

            string cmd1 = "To move use the NumPad keys in all directions.";
            string wrn = "NOTE: Please turn the NumLock on, on the NumPad.";
            string cmd2 = "Other actions:  (L) - Look Around\t(Q) - Quit";

            Console.WriteLine(setas1 + "\t" + cmd1);
            Console.WriteLine(setas2 + "\t" + wrn);
            Console.WriteLine(setas3 + "\t" + cmd2);
        }

        private void MapGrid()
        {
            //Side Information
            int pX = player.CoorX;
            int pY = player.CoorY;

            int eX = exit.CoorX;
            int eY = exit.CoorY;

            int i = 0;

            List<string> allStrings = new List<string>();

            allStrings.Add($"\t\tCurrent coordinates P:\tx = {pX}\ty = {pY}");
            allStrings.Add($"\t\tCurrent coordinates E:\tx = {eX}\ty = {eY}");
            allStrings.Add($"\t\tCurrent HP:\t{player.HP}");

            //----

            for (int y = 0; y < board.Row; y++)
            {
                Console.Write("\t\t");

                for (int x = 0; x < board.Column; x++)
                {
                    if (x == player.CoorX && y == player.CoorY)
                    {
                        Console.Write(" P ");
                    }
                    else
                    {
                        Console.Write(" \u23FA ");
                    }
                }

                if (i < allStrings.Count)
                {
                    Console.WriteLine($"{allStrings[i]}");
                    i++;
                }
                else
                {
                    Console.Write("\n");
                }
                
                Console.Write("\n");
            }
        }

        public void Render()
        {
            LevelLegend();
            MapGrid();
            ControlLegend();
        }
    }
}
