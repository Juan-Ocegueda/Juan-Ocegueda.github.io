using System;
using System.Collections.Generic;
using System.Text;
using static VerseSong.Colors;
namespace VerseSong
{
    class Verse
    {
        public string[] Days = new string[]
        {
            "first",
            "second",
            "third",
            "fourth",
            "fifth",
            "sixth",
            "seventh",
            "eighth",
            "ninth",
            "tenth",
            "eleventh",
            "twelvth",
        };
        public string[] Gifts = new string[]
        {
            "partridge in a pear tree",
            "two turtle doves",
            "three French hens",
            "Four calling birds",
            "five golden rings",
            "six geese a laying",
            "seven swans a swimming",
            "eight maids a milking",
            "nine ladies dancing",
            "Ten lords a leaping",
            "eleven pipers piping",
            "twelve drummers drumming",
        };

        public Verse()
        {
            Sing();
        }

        public void Sing()
        {
            for(int d = 0; d < Days.Length;d++)
            {
                //Execute statements

                Green($"\nOn the {Days[d]} day of Christmas my true love gave to me...");

                //format the first day in a diff way

                if(d == 0)
                {
                    Blue($"\n{Gifts[d]}.");
                    Console.ReadKey(true);
                    Console.Clear();

                }else
                {
                    for (int g = d; g > 0; g--)
                    {
                        if(g == 4)
                        {
                            White($"\n    {Gifts[g]},");
                        }
                        else
                        {
                            Blue($"\n    {Gifts[g]},");
                        }
                    }
                    Blue($"\n{Gifts[0]}.");
                    Console.ReadKey(true);
                    Console.Clear();

                }
            }
        

           

        }
    }
}
