﻿using System;

namespace Lab2_Part1_Ex2
{
    class Employee
    {
        private int empID;

        public Employee(int empId)
        {
            empID = empId;
        }

        public override string ToString()
        {
            return empID.ToString();
        }
    }

    class ObjectArray
    {
        public void Run()
        {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];
            // populate the array
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);
            }

            Console.WriteLine("The int array...");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i].ToString());
            }

            Console.WriteLine("\nThe employee array...");
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = new ObjectArray();
            arr.Run();
            Console.ReadLine();
        }
    }
}