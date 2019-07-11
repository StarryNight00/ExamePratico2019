using System;
using System.Text;

namespace RogueProg
{
    /// <summary>
    /// Class that starts the program itself.
    /// </summary>
    class Program
    {
        /// <summary>
        /// String that saves the arguments given on the bash console.
        /// </summary>
        public static string[] arguments;

        /// <summary>
        /// The Main-loop. Starts the game loops by calling the menu.
        /// </summary>
        /// <param name="args">Arguments string.</param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            arguments = args;

            Menu menu = new Menu();

            menu.FirstScreen();
            Console.Write("\n\n\n\n\n");
            Console.Read();
            
            menu.MenuController();

        }
    }
}
