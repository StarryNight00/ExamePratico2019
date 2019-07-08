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
        BoardRender render;
        Player player;
        Exit exit;

        bool winCheck;

        internal void GameInit()
        {
            board.GetArgs();

            winCheck = false;

            player = new Player(board);
            exit = new Exit(board);
            render = new BoardRender(board, player, exit);


            do
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                render.Render();
                player.MovePlayer();
                WinCheck();

            } while (player.HP > 0 || winCheck == false);


        }

        private bool WinCheck()
        {
            int pX = player.CoorX;
            int pY = player.CoorY;

            int eX = exit.CoorX;
            int eY = exit.CoorY;

            if (pX == eX && pY == eY)
            {
                winCheck = true;
            }

            return winCheck;
        }
        
    }
}
