using System;

namespace Lab3_Part1_Ex1
{
    class Car
    {
        public string make;
        public string model;
        public string color;

        public int yearBuilt;

        // define the methods
        public void Start()
        {
            Console.WriteLine(model + "started");
        }

        public void Stop()
        {
            Console.WriteLine(model + "stopped");
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // declare a Car object reference named myCar
            Car myCar;
            // create a Car object, and assign its address to myCar
            Console.WriteLine("Creating a Car object and assigning " +
                              "its memory location to myCar");
            myCar = new Car();
            // assign values to the Car object&#39;s fields using myCar
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;
            // display the field values using myCar
            Console.WriteLine("myCar details:");
            Console.WriteLine("myCar.make = " + myCar.make);
            Console.WriteLine("myCar.model= " + myCar.model);
            Console.WriteLine("myCar.color = " + myCar.color);
            Console.WriteLine("myCar.yearBuilt=" + myCar.yearBuilt);
            // call the methods using myCar
            myCar.Start();
            myCar.Stop();
            // declare another Car object reference and
            // create another Car object
            Console.WriteLine("Creating another Car object and"
                              + "assigning its memory location to redPorsche");
            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            Console.WriteLine("redPorsche is a " + redPorsche.model);
            //change the object referenced by the myCar object
            ////reference to the object referenced by redPorshe
            Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            Console.WriteLine("myCar details:");
            Console.WriteLine("myCar.make = " + myCar.make);
            Console.WriteLine("myCar.model = " + myCar.model);
            Console.WriteLine("myCar.color = " + myCar.color);
            Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);
            // assign null to myCar (myCar will no longer reference
            //an object)

            myCar = null;
            Console.ReadLine();
        }
    }
}