using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class Menu
    {
        //Menu interface

        /// <summary>
        /// Variable to call on the MenuOptions class's methods.
        /// </summary>
        private MenuOptions options = new MenuOptions();

        /// <summary>
        /// Player input string variable while on the menu screen.
        /// </summary>
        private string input;

        /// <summary>
        /// Method that prints an intro screen when program opens.
        /// </summary>
        public void FirstScreen()
        {
            Console.WriteLine("-------");
            Console.WriteLine("Press Any Key");
            //make first screen
        }

        /// <summary>
        /// Menu interface with options printed.
        /// </summary>
        private void MenuPresentation()
        {
            Console.WriteLine("Pratical Exam Project\n\n");
            Console.WriteLine("1 -- New Game");
            Console.WriteLine("2 -- High Scores");
            Console.WriteLine("3 -- Credits");
            Console.WriteLine("4 -- Quit");
        }

        public void MenuController()
        {
            do
            {
                MenuPresentation();
                Console.WriteLine("\n\n\n");
                Console.Write("> ");
                Console.WriteLine(input = Console.ReadLine());


                switch (Convert.ToInt32(input))
                {
                    case 1:
                        options.NewGame();
                        break;
                    case 2:
                        options.HighScores();
                        break;
                    case 3:
                        options.Credits();
                        break;
                    case 4:
                        options.Quit();
                        break;
                }

            } while (Convert.ToInt32(input) != 1);

        }
        
    }
}
