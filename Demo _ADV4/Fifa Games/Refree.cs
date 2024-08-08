using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__ADV4.Fifa_Games
{
    internal class Refree
    {
        public string RefreeName { get; set; }

        //Call Back Funcation
        public void Look()
        {
            Console.WriteLine($"Refree : {RefreeName} Is Looking At Ball ..........");
        }
    }
}
