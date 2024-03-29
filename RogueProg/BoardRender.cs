﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    /// <summary>
    /// Class that focuses on the graphic rendering of the game.
    /// </summary>
    class BoardRender
    {
        private Board board;
        private Player player;
        private Exit exit;

        /// <summary>
        /// Render constructor.
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="player"></param>
        /// <param name="exit"></param>
        public BoardRender(Board board, Player player, Exit exit)
        {
            this.board = board;
            this.player = player;
            this.exit = exit;
        }

        /// <summary>
        /// Method with all the string related to the level.
        /// To be shown at the top.
        /// </summary>
        private void LevelLegend()
        {
            string leg2 = $"Dificulty: {board.d} |";
            string leg3 = $" Map Size: {board.Column}x{board.Row}";

            Console.WriteLine("\n>>> " + leg2 + leg3 + " <<<\n\n");
        }

        /// <summary>
        /// Method with all the strings related to the playable controls.
        /// 
        /// </summary>
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

        /// <summary>
        /// Method that renders the 'Look Around' action map.
        /// This method has extra cycles to verify if the Exit is at any of the
        /// neighboring coordinates.
        /// </summary>
        private void MapLookAround()
        {
            //Side Information
            int pX = player.CoorX;
            int pY = player.CoorY;

            int eX = exit.CoorX;
            int eY = exit.CoorY;

            int i = 0;

            List<string> allStrings = new List<string>();

            allStrings.Add($"\t\tPlayer P | Coordinates:\tx = {pX}\ty = {pY}");
            allStrings.Add($"\t\tExit - E");
            //allStrings.Add($"\t\tCurrent coordinates E:\tx = {eX}\ty = {eY}");
            allStrings.Add($"\t\tCurrent Player HP:\t{player.HP}");

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
                    else if (y == player.CoorY - 1 && x == player.CoorX && y == exit.CoorY && x == exit.CoorX)
                    {
                        //up
                        Console.Write(" E ");
                    }
                    else if (y == player.CoorY - 1 && x == player.CoorX + 1 && y == exit.CoorY && x == exit.CoorX)
                    {
                        //upRight
                        Console.Write(" E ");
                    }
                    else if (y == player.CoorY && x == player.CoorX + 1 && y == exit.CoorY && x == exit.CoorX)
                    {
                        //right
                        Console.Write(" E ");
                    }
                    else if (y == player.CoorY + 1 && x == player.CoorX && y == exit.CoorY && x == exit.CoorX)
                    {
                        //down
                        Console.Write(" E ");
                    }
                    else if (y == player.CoorY + 1 && x == player.CoorX + 1 && y == exit.CoorY && x == exit.CoorX)
                    {
                        //downRight
                        Console.Write(" E ");
                    }
                    else
                    {
                        Console.Write(" . ");
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

            player.lookAround = false;

        }

        /// <summary>
        /// Method that renders the normal map.
        /// This method verifies if the coordinates currently being drawn
        /// are the same as the player's, beside rendering the side legend.
        /// </summary>
        private void MapGrid()
        {
            //Side Information
            int pX = player.CoorX;
            int pY = player.CoorY;

            int eX = exit.CoorX;
            int eY = exit.CoorY;

            int i = 0;

            List<string> allStrings = new List<string>();

            allStrings.Add($"\t\tPlayer P | Coordinates:\tx = {pX}\ty = {pY}");
            allStrings.Add($"\t\tExit - E");
            //allStrings.Add($"\t\tCurrent coordinates E:\tx = {eX}\ty = {eY}");
            allStrings.Add($"\t\tCurrent Player HP:\t{player.HP}");

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
                        Console.Write(" . ");
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

        /// <summary>
        /// Method that calls on each screen. When on the main gameloop,
        /// there's only need to call for this method.
        /// </summary>
        public void Render()
        {
            LevelLegend();
            if (player.lookAround == true)
            {
                MapLookAround();
            }
            else
            {
                MapGrid();
            }
            ControlLegend();
        }
    }
}
