using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace MiniGame
{
    class Game
    {
        private List<Location> gameLocations = new List<Location>();
        private Player MyPlayer;
        private string data = "data.csv";
        public Game()
        {
            //LoadGame();
            LoadGameIO();
            Start();

            while(true)
            {
                Travel();
            }
        }

        public void LoadGame()
        {
            gameLocations.Add(new Location("Columbia", "College", new Character("Richard", "Insructor", new string[] { "Hello.", "How are you?", "Lets go home."}),new Item("Wrench", 20)));
        }
        public void LoadGameIO()
        {
            foreach(var item in File.ReadAllLines(data))
            {
                var fields = item.Split(',');
                gameLocations.Add(new Location(fields[0], fields[1], new Character(fields[2], fields[3], new string[] { fields[4], fields[5], fields[6]}),new Item( fields[7], Convert.ToInt32(fields[8]))));
            }
        }
        public void Start()
        {
            WriteLine("Enter your player name:");
            MyPlayer = new Player(ReadLine());

            WriteLine($"Hello, { MyPlayer.PlayerName}");
            //foreach(Location locale in gameLocations)
           // {
            //    WriteLine($"You find yourself at {locale.LocationDescription} and you see your{locale.LocationCharacter.CharacterType} looking at {locale.LocationItem.ItemName}.");
          //  }
            
        }


        public void Travel()
        {
            WriteLine("Where would you like to go?");
            for(int i = 0; i < gameLocations.Count; i++)
            {
                WriteLine($"{i + 1} {gameLocations[i].LocationName}");
            }
            try
            {
                int choice = Convert.ToInt32(ReadLine());
                if(MyPlayer.UpdateLocation(gameLocations[choice - 1]))
                {
                    WriteLine($"You have traveled to {MyPlayer.PlayerLocation.LocationName}");
                }
                else
                {
                    WriteLine("Sorry, you cannot go there.");
                }

            }
            catch (Exception)
            {
                WriteLine("Please enter a valid option.");
            }
            
            ReadKey(true);
            Clear();
            
        }
    }
}
