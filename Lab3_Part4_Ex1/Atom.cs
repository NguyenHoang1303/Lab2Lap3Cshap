using System;

namespace Lab3_Part4_Ex1
{
    public class Atom
    {
        public int Number { get; set; }
        public string FullName { get; set; }
        public float Weight { get; set; }

        public bool accept()
        {
            Console.WriteLine("Enter Full name:");
            FullName = Console.ReadLine();
            Console.WriteLine("Enter number:");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight:");
            Weight = Convert.ToSingle(Console.ReadLine());
            return true;
        }

        public void display()
        {
            Console.WriteLine($"Name: {FullName}, Number: {Number}, Weight: {Weight}");
        }
    }
}