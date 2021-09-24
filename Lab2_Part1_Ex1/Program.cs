using System;

namespace Lab2_Part1_Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var now = DateTime.Now;
            var rand = new Random((int)now.Millisecond);
            var arr = new int[10];
            for (var x = 0; x < arr.Length; ++x)
            {
                arr[x] = rand.Next() % 100;
            }
            var total = 0;
            Console.Write("Array values are");
            foreach (var val in arr)
            {
                total += val;
                Console.Write(val + ",");
            }
            Console.WriteLine("\nAnd the average is {0,0:F1}",
            (double)total / (double)arr.Length);

            Console.ReadLine();
        }
    }
}