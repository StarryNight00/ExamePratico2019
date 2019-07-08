using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class MenuOptions
    {
        //Methods for each menu option
        //New Game calls Game

        internal void NewGame()
        {
            //initialises Game
            Console.WriteLine("\n\nLet's Start");
            Console.Read();

            Game game = new Game();
            game.GameInit();
        }

        internal void HighScores()
        {
            Console.WriteLine("\n\n\t\t\tNo information is available at the moment.");
            Console.Read();
        }

        internal void Credits()
        {
            Console.WriteLine("\n\n\t\t\tDeveloped by");
            Console.WriteLine("\n\t\tCatarina Matias\ta21801693");
            Console.Read();
        }

        internal void Quit()
        {
            Environment.Exit(0);
        }

    }
}
