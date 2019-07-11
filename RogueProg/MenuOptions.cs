using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    /// <summary>
    /// All the methods from the options presented on the Main Menu.
    /// Serves as a bridge to start the actual game.
    /// </summary>
    class MenuOptions
    {
        /// <summary>
        /// Information string for the HighScore screen.
        /// </summary>
        private string highScore = "No information is available at the moment.";

        /// <summary>
        /// Information string for the Credits screen.
        /// </summary>
        private string credits = "Developed by\n\n\t\tCatarina Matias\ta21801693";

        /// <summary>
        /// Method that creates a new game with reshuffled values.
        /// </summary>
        internal void NewGame()
        {
            Console.WriteLine("\n\n\n>> Start Game\n\n");
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
