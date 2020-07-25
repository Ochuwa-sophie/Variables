using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string Employees = "Don't type funny things.";

            char[] charArray = Employees.ToCharArray();
            Array.Reverse(charArray);

           foreach (char EmployeesChar in charArray)
           {
               Console.Write(EmployeesChar);
           }
            Console.ReadLine();
        }
    }
}
