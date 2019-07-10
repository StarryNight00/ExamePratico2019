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

            Console.WriteLine("\u2196 \u2191 \u2197");
            Console.WriteLine("\u2190 \u263C \u2192");
            Console.WriteLine("\u2199 \u2193 \u2198");

            Menu menu = new Menu();

            menu.FirstScreen();
            Console.Read();
            
            menu.MenuController();

        }
    }
}
