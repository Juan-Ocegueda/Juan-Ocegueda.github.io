using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGame
{
    class Player
    {
        public string PlayerName { get; private set; }
        public Location PlayerLocation { get; private set; }
        private List<Item> Inventory = new List<Item>();

        public Player() { }
        public Player(string name)
        {
            PlayerName = name;
        }
        public bool UpdateLocation(Location newLocation)
        {
            if (PlayerLocation != newLocation)
            {
                PlayerLocation= newLocation;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
