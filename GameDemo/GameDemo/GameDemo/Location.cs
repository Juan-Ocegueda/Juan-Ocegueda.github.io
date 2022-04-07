using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Location
    {
        public string LocName { get; private set; }

        public Location (string name)
        {
            LocName = name;
        }
    }
}
