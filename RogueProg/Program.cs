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

            Menu menu = new Menu();

            menu.FirstScreen();
            Console.ReadKey();
            
            menu.MenuController();

        }
    }
}
