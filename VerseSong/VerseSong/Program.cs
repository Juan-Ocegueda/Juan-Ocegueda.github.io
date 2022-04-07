using System;
using static VerseSong.Colors;

namespace VerseSong
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = @"
 _ ____        _                          __     ___ _          _     _                       
/ |___ \    __| | __ _ _   _ ___    ___  / _|   / __\ |__  _ __(_)___| |_ _ __ ___   __ _ ___ 
| | __) |  / _` |/ _` | | | / __|  / _ \| |_   / /  | '_ \| '__| / __| __| '_ ` _ \ / _` / __|
| |/ __/  | (_| | (_| | |_| \__ \ | (_) |  _| / /___| | | | |  | \__ \ |_| | | | | | (_| \__ \
|_|_____|  \__,_|\__,_|\__, |___/  \___/|_|   \____/|_| |_|_|  |_|___/\__|_| |_| |_|\__,_|___/
                       |___/                                                                  ' ";

            Console.Title = "12 Days of Christmas";

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            White(title);
            Console.ReadKey(true);


            new Verse();


            Console.ReadKey();
        }
    }
}
