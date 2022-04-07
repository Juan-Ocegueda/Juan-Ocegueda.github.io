using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGame
{
    class Item
    {
        public string ItemName { get; }
        public int ItemWeight { get; }
        public Item(string name, int weight)
        {
            ItemName = name;
            ItemWeight = weight;
        }
    }
}
