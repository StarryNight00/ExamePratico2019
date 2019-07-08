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
            Console.Clear();
            Console.WriteLine("\n\nLet's Start");
            Console.ReadKey();
        }

        internal void HighScores()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t\tNo information is available at the moment.");
            Console.ReadKey();
        }

        internal void Credits()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t\tDeveloped by");
            Console.WriteLine("\n\t\tCatarina Matias\ta21801693");
            Console.ReadKey();
        }

        internal void Quit()
        {
            Environment.Exit(0);
        }

    }
}
