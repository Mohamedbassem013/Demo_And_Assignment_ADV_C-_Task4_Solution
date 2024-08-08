using Demo_And_Assignment_ADV_C__Task4_Solution.part_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_And_Assignment_ADV_C__Task4_Solution.part_04
{
    internal class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int quota)
        {
            return AchievedTarget >= quota;
        }

    }
}
