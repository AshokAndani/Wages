using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee PayRoll App");
            Console.WriteLine("Enter Empoyee Name: ");
            string name = Console.ReadLine();
            Random random = new Random();
            int isPresent = random.Next(0, 2);
            if (isPresent == 0)
            {
                
                Console.WriteLine(name + " is Absent");
            }
            else
            {
                int totalWage = 8 * 20;
                Console.WriteLine(name + " is Present and wage is: "+totalWage);
            }
        }
    }
}
