using System;
using System.Collections.Generic;
using System.Text;
using static System.Console
using 


namespace GameDemo
{
    class Game
    {
        private Player myPlayer = new Player();
        private List <Location> locations = new List<Location>();
        private List<Item> items = new List<Item>();
        private List<string> levelDialogue = new List<string>();
        private string gameData = "GameData.txt";

        public Game()
        {
            // Run my game
            LoadGameData();
            SetUpPlayer();
            while (Play())
            {
                continue;
            }
            EndGame();
        }
        public void LoadGameData()

        {
            foreach(var item in File.ReadAllLines(gameData))
            {
                var fields = item.Split(';');
                locations.Add(new Location(fields[0]));
                items.Add(new Item(fields[0]));
                levelDialogue.Add(fields[2]);


            }
        }

        public void SetUpPlayer()
        {
            WriteLine("Welcome to Middle-Earth!");

            while (true)
            {
                WriteLine("Choose your player name:");
                try
                {
                    myPlayer.UpdateName(ReadLine());
                }catch (Exception)
                {
                    
                }
                WriteLine($"You chose {myPlayer.PlayerName} \n\nPress \"N\" key to pick something else or any other key to continue.");

                ConsoleKeyInfo input = ReadKey();

                if(input.Key != ConsoleKey.N)
                {
                    break;
                }
                Clear();
            }

        }
        public bool Play()
        {
            int choice = 0;
            while (true)
            {
                Clear();
                WriteLine("You arrive at a crossroad, you can go:");
                for (int i = 0;i< locations.Count; i++ >)
                {
                    WriteLine($"{i + 1}: {locations[i].LocName}");
                }
                WriteLine("Enter number to select a loation to travel to.");
                try
                {
                    choice = Convert.ToInt32(ReadLine());
                    choice--;
                    if (choice >= 0 && choice < locations.Count)
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }catch (Exception)
                {
                    WriteLine("Not a valid option, press any key to try again");
                    ReadKey(true);
                }
                Travel(locations[choice], choice);
                if(myPlayer.CheckInventory() == items.Count)
                {
                    return false;
                }
                return true;
            }
        }
        public void Travel(Location L, int dilogue)
        {
            while (true)
            {
                Clear();
                WriteLine($"Welcome to {L.LocName}! \n {levelDialogue[dilogue]}");
                WriteLine("Y to accept, N to ignore");

               if (input.Key != ConsoleKey.N)
                {
                    WriteLine("Suit Yourself");
                    break;
                } else if (input.Key == ConsoleKey.Y)
                {
                    WriteLine(myPlayer.UpdateInventory(items[dilogue]));
                    break;
                }
                else
                {
                    WriteLine("Did not recognize input");
                    ReadKey(true);
                }
            }
            ReadKey(true);
        }
        public void EndGame()
        {
            Clear();
            WriteLine("Congrats you have collected:");
            WriteLine(myPlayer.);
            whatever
             
        }
    }
}
