using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGame
{
    class Location
    {
        public string LocationName { get; }
        public string LocationDescription { get; }
        public Character LocationCharacter {get;}
        public Item LocationItem { get; }

        public Location (string name, string description, Character characeter, Item item)
        {
            LocationName = name;
            LocationDescription = description;
            LocationItem = item;
        }
    }
}
