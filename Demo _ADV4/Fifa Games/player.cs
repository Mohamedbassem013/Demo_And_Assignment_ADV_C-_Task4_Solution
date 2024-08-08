using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__ADV4.Fifa_Games
{
    internal class player
    {
        public string playName { get; set; }
        public string TeamName { get; set; }

        //Call Back Funcation

        public void Run()
        {
            Console.WriteLine($"Player : {playName} Is Running ..........");
        }
    }
}
