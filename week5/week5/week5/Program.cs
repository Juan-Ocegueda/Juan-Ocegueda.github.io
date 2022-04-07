using System;
using static System.Console;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            Game MyGame = new Game();
            MyGame.Start();
            Console.ReadKey(true);
        }
    }

}
