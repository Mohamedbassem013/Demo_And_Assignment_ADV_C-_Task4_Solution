using Demo_And_Assignment_ADV_C__Task4_Solution.part_01;
using Demo_And_Assignment_ADV_C__Task4_Solution.part_02;
using Demo_And_Assignment_ADV_C__Task4_Solution.part_03;
using Demo_And_Assignment_ADV_C__Task4_Solution.part_04;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Assignment Event C# Advanced

        #region part 1 and part 2
        //Step 0 : Create a department 
        Department department = new Department() { DeptID = 100, DeptName = "Web Development" };

        //Step 1 : Create Employees
        Employee employee01 = new Employee() { EmployeeID = 1, BirthDate = new DateTime(1960, 1, 1), VacationStock = 5 };
        Employee employee02 = new Employee() { EmployeeID = 2, BirthDate = new DateTime(1999, 1, 1), VacationStock = 10 };
        Employee employee03 = new Employee() { EmployeeID = 3, BirthDate = new DateTime(1985, 1, 1), VacationStock = -1 };

        //Step 2 : Add the staff to thier Department
        department.AddStaff(employee01);
        department.AddStaff(employee02);
        department.AddStaff(employee03);

        Console.WriteLine("Intial staff list before laying off:");
        department.DisplayStaff();

        //Step 3 : Call the EndOf Year Opeation to check the layoff Condtions

        employee01.EndOfYearOperation();
        employee02.EndOfYearOperation();
        employee03.EndOfYearOperation();

        //Step 4 : Display the updated staff list after layoffs
        Console.WriteLine("\nUpdated Staff List after Layoffs:");
        department.DisplayStaff();
        #endregion

        #region part 03
        // Club club = new Club { ClubID = 1, ClubName = "Executive Club" };
        //
        // Employee emp1 = new Employee { Name = "Mohamed", Age = 20, VacationStock = 10 };
        // Employee emp2 = new Employee { Name = "Bassem", Age = 62, VacationStock = 5 };
        // Employee emp3 = new Employee { Name = "ATTA", Age = 40, VacationStock = -5 };

        // club.AddMember(emp1);
        // club.AddMember(emp2);
        // club.AddMember(emp3);

        // club.ListMembers();
        // emp1.CheckVacationStock();
        // emp2.CheckVacationStock();
        // emp3.CheckVacationStock();

        // club.ListMembers();
        #endregion

        #region part 4

        //SalesPerson salesPerson = new SalesPerson();
        //salesPerson.Name = "Ali Ahmed";
        //salesPerson.Age = 35;
        //salesPerson.AchievedTarget = 90;
        //
        //int salesQuota = 100;
        
        //if (!salesPerson.CheckTarget(salesQuota))
        //{
        //    Console.WriteLine($"{salesPerson.Name} has failed to achieve the sales target and will be fired.");
        //}
        //else
        //{
        //    Console.WriteLine($"{salesPerson.Name} has achieved the sales target and will not be fired.");
        //}
        
        //BoardMember boardMember = new BoardMember();
        //boardMember.Name = "Mohamed Bassem";
        //boardMember.Age = 65;

        //boardMember.Resign();

        //if (boardMember.Age > 60)
        //{
        //    Console.WriteLine($"{boardMember.Name} is over 60 years old but will not be fired due to age.");
        //}
        //Console.WriteLine($"{boardMember.Name} will remain a member of company clubs forever.");

        #endregion
    }
    #endregion
}
