using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    static class LearnStatic
    {
        // static = modifier to declare a static member, which belongs to the class itself
        //          rather than to any specific object


        Car1 car11 = new Car1("Mustang");
        Car1 car22 = new Car1("Corvette");
        Car1 car33 = new Car1("Lambo");

        Console.WriteLine(Car1.numberOfCars);
            Car1.StartRace();

            Console.ReadKey();
    }

    class Car1
    {
        String model;
        public static int numberOfCars;

        public Car1(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
