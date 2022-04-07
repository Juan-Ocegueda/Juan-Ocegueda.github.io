using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Item
    {
        public string ItemName { get; private set; }
        public Item(string name)
        {
            ItemName = name;
        }
    }
}
