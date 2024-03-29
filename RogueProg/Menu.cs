﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    /// <summary>
    /// Menu Class. Controls the Main Menu presented to the player. 
    /// </summary>
    class Menu
    {
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
            Console.WriteLine("\n\n\n\n\n\t\t\t-------");
            Console.WriteLine("\t\t      Press Any Key");
            Console.WriteLine("\t\t\t-------");
        }

        /// <summary>
        /// Menu interface with options printed.
        /// </summary>
        private void MenuPresentation()
        {
            Console.WriteLine("\n\n\n\n\n\t\t   Pratical Exam Project\n\n");
            Console.WriteLine("\t\t\t1 -- New Game");
            Console.WriteLine("\t\t\t2 -- High Scores");
            Console.WriteLine("\t\t\t3 -- Credits");
            Console.WriteLine("\t\t\t4 -- Quit");
        }

        /// <summary>
        /// Method that controls the Main menu presentation.
        /// Calls on each option (from MenuOptions class) when it's selected.
        /// </summary>
        public void MenuController()
        {
            do
            {
                MenuPresentation();
                Console.WriteLine(input = Console.ReadLine());

                if (input == null || input == "")
                {
                    Console.Write("\n\n\n> ");
                    Console.WriteLine(input = Console.ReadLine());
                }

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
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            } while (Convert.ToInt32(input) != 1);

        }
        
    }
}
