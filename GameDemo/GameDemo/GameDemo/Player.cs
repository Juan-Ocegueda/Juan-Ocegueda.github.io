using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Player
    {
        public string PlayerName { get; private set; }
        private List<Item> PlayerInventory = new List<Item>();

        public Player()
        {

        }

        public Player (string name)
        {
            PlayerName = name;
        }

        public void UpdateName (string name)
        {
            PlayerName = name;
        }
        public string UpdateInventory(Item i)
        {
            string result;
            if (this.PlayerInventory.Contains(i))
            {
                result = $"You already have the {i.ItemName} genius.";
            }
            else
            {
                this.PlayerInventory.Add(i);
                result = $"Ayo {i.ItemName} has been collected goofy";
            }
            return result;
        }


        public string DisplayInventory()
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in PlayerInventory)
            {
                result.Append($"{item.ItemName}\n");

            }
            return result.ToString();
        }
        public int CheckInventory()
        {
            return this.PlayerInventory.Count;
        }
    }
}
