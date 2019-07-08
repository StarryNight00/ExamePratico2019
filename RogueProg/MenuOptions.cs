using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class MenuOptions
    {
        //Methods for each menu option
        //New Game calls Game

        //All information strings
        string highScore = "No information is available at the moment.";
        string credits = "Developed by\n\n\t\tCatarina Matias\ta21801693";

        internal void NewGame()
        {
            //initialises Game
            Console.WriteLine("\n\nLet's Start\n\n");
            Console.ReadKey();


            Game game = new Game();
            game.GameInit();
        }

        internal void HighScores()
        {
            Console.Write("\n\n\t\t\t");
            Console.WriteLine(highScore);
            Console.Write("\n\n\n> ");
            Console.ReadKey();

        }

        internal void Credits()
        {
            Console.Write("\n\n\t\t\t");
            Console.WriteLine(credits);
            Console.Write("\n\n\n> ");
            Console.ReadKey();
        }

        internal void Quit()
        {
            Environment.Exit(0);
        }

    }
}
