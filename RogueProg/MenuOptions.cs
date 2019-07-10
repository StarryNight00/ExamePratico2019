using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class MenuOptions
    {
        //Methods for each menu option

        //All information strings
        string highScore = "No information is available at the moment.";
        string credits = "Developed by\n\n\t\tCatarina Matias\ta21801693";

        /// <summary>
        /// Method that creates a new game with reshuffled values.
        /// </summary>
        internal void NewGame()
        {
            //initialises Game
            Console.WriteLine("\n\nLet's Start");
            Console.Read();


            Game game = new Game();
            game.GameInit();
        }

        /// <summary>
        /// Method that prints the highest scores information on te console.
        /// </summary>
        internal void HighScores()
        {
            Console.Write("\n\n\t\t\t");
            Console.WriteLine(highScore);
            Console.Write("\n\n\n> ");
            Console.Read();
        }

        /// <summary>
        /// Method that print the project's credits information on the console.
        /// </summary>
        internal void Credits()
        {
            Console.Write("\n\n\t\t\t");
            Console.WriteLine(credits);
            Console.Write("\n\n\n> ");
            Console.Read();
        }

        /// <summary>
        /// Quit Method. Shuts down the program running in console.
        /// </summary>
        internal void Quit()
        {
            Environment.Exit(0);
        }

    }
}
