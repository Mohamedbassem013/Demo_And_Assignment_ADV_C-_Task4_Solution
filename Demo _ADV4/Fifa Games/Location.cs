using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__ADV4.Fifa_Games
{
    internal class Location
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public override string ToString()
        {
            return $" X : {x} , Y : {y} , Z : {z}";
        }
    }
}
