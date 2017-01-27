using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car
            {
                Id = 1,
                IsMoving = true,
                Name = "First Car"
            };

            Car c2 = new Car
            {
                Id = 1,
                IsMoving = true,
                Name = "First Car"
            };

            // Check if c1 and c2 are same
            // Using Equals method in Car class
            Console.WriteLine(c1.Equals(c2));
            // True

            Car c3 = new Car
            {
                Id = 1,
                IsMoving = true,
                Name = "False Car"
            };

            // Check if c1 and c3 are same
            Console.WriteLine(c1.Equals(c3));
            // False


            // List of Cars contains only c1
            List<Car> cars = new List<Car>();
            cars.Add(c1);
            
            Console.WriteLine();
            Console.WriteLine("List compare");

            // Compare if c1 in list is same as c2
            // List.Contains() use Car.Equals() method by default
            Console.WriteLine(cars.Contains(c2));
            // True

            // Compare if c1 in list is same as c3
            Console.WriteLine(cars.Contains(c3));
            // False


            Console.ReadKey();
        }
    }
}
