using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class Game
    {
        //Call game realted variables and methods
        //Controls gameloop

        /// <summary>
        /// Calls Board Class and initializes the variable.
        /// </summary>
        Board board = new Board();

        /// <summary>
        /// Calls BoardRender Class without initiazing the variable.
        /// Variable is initiaized in GameInit.
        /// </summary>
        BoardRender render;

        /// <summary>
        /// Calls Player Class without initiazing the variable.
        /// Variable is initiaized in GameInit.
        /// </summary>
        Player player;

        /// <summary>
        /// Calls Exit Class without initiazing the variable.
        /// Variable is initiaized in GameInit.
        /// </summary>
        Exit exit;

        /// <summary>
        /// Calls MenuOptions Class and initializes the variable.
        /// </summary>
        MenuOptions resetGame = new MenuOptions();

        /// <summary>
        /// Victory check variable.
        /// </summary>
        bool winCheck;


        /// <summary>
        /// Gameloop method.
        /// Controls the gameloop and its variables.
        /// </summary>
        internal void GameInit()
        {
            board.GetArgs();

            winCheck = false;

            player = new Player(board);
            exit = new Exit(board);
            render = new BoardRender(board, player, exit);

            do
            {
                render.Render();
                player.MovePlayer();
                WinCheck();

                if(player.HP <= 0)
                {
                    break;
                }

            } while (winCheck == false);


            //After game victory check and reset

            if (winCheck == true)
            {
                YouWon();
            }
            else if (winCheck == false)
            {
                YouLost();
            }

            resetGame.NewGame();
        }

        /// <summary>
        /// Method that keeps track of the Player and Exit current coordinates.
        /// If these values are equal, the victory condition is true.
        /// </summary>
        private void WinCheck()
        {
            int pX = player.CoorX;
            int pY = player.CoorY;

            int eX = exit.CoorX;
            int eY = exit.CoorY;

            if (pX == eX && pY == eY)
            {
                winCheck = true;
            }
        }

        /// <summary>
        /// Method that prints an information screen in the console.
        /// The Player has won.
        /// </summary>
        private void YouWon()
        {
            Console.WriteLine("\n\n\nAmazing!");
            Console.WriteLine("\nYou have won!!");
            Console.ReadKey();
        }

        /// <summary>
        /// Method that prints an information screen in the console.
        /// The player has lost.
        /// </summary>
        private void YouLost()
        {
            Console.WriteLine("\n\n\nOh no!");
            Console.WriteLine("\nYou have lost!!");
            Console.ReadKey();
        }

    }
}
