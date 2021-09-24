using System;

namespace Lab3_Part4_Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee("Nguyen", "Hoang", "Hung Yen", 12, 5000000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine("Bonus: " + employee.Bonus(0.2));
        }
    }
}