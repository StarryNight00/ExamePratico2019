using System;
using System.Collections.Generic;
using System.Text;

namespace RogueProg
{
    class Board
    {
        internal int Row { get; private set; }
        internal int Column { get; private set; }
        internal int d;

        /// <summary>
        /// Function that reads the args string to transfer the values.
        /// </summary>
        internal void GameInit()
        {
            //String array that receives the arguments in main
            string[] values = Program.arguments;

            for (int i = 0; i < values.Length; i++)
            {
                switch (values[i])
                {
                    case "-r":
                        Row = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-c":
                        Column = Convert.ToInt32(values[i + 1]);
                        break;
                    case "-d":
                        d = Convert.ToInt32(values[i + 1]);
                        break;
                }
            }
        }
    }
}
