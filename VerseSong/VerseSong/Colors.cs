using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace VerseSong
{
    class Colors
    {
        public static void Red(string msg)
        {
            ForegroundColor = ConsoleColor.Red;
            Write(msg);
        }
        public static void Blue(string msg)
        {
            ForegroundColor = ConsoleColor.Blue;
            Write(msg);
        }
        public static void Green(string msg)
        {
            ForegroundColor = ConsoleColor.Green;
            Write(msg);
        }
        public static void White(string msg)
        {
            ForegroundColor = ConsoleColor.White;
            Write(msg);
        }
    }
}
