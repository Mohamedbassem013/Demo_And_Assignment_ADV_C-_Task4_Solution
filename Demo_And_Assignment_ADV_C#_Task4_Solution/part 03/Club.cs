using Demo_And_Assignment_ADV_C__Task4_Solution.part_01;
using Demo_And_Assignment_ADV_C__Task4_Solution.part_04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_And_Assignment_ADV_C__Task4_Solution.part_03
{
    internal class Club : Employee
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        public List<Employee> Members { get; } = new List<Employee>();

        public void AddMember(Employee E)
        {
            Members.Add(E);
        }


        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Employee.Age > 60)
            {
                Console.WriteLine($"{e.Employee.Name} is over 60 and will remain a member of {ClubName}.");
            }
            else if (e.Employee.VacationStock < 0)
            {
                Members.Remove(e.Employee);
                Console.WriteLine($"{e.Employee.Name} has been removed from {ClubName} due to insufficient vacation stock.");
            }
        }


        public void ListMembers()
        {
            Console.WriteLine($"Members of {ClubName}:");
            foreach (var member in Members)
            {
                Console.WriteLine($"- {member.Name}, Age: {member.Age}, Vacation Stock: {member.VacationStock}");
            }
        }
    }
}
