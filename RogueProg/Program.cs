using System;
using System.Text;

namespace RogueProg
{
    class Program
    {
        public static string[] arguments;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            arguments = args;

            //Calls the menu class
            Menu menu = new Menu();

            menu.FirstScreen();
            Console.Read();
            menu.MenuController();
        }
    }
}
