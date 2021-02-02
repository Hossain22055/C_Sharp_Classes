using System;
using System.Collections.Generic;

namespace C_Sharp_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car("Honda", "Civic", 2021);
            Car carTwo = new Car("Honda", "Fit", 2020);
            Car catThree = new Car("Toyota", "Corolla", 2021);

            Car nameAndPrice = new Car("Honda", 23000);
            Car nP = new Car("Toyota", 25000);

            var carList = new List<Car>() { carOne, carTwo, catThree, nameAndPrice, nP };

            foreach( var carListOne in carList)
            {
                Console.WriteLine($" {carListOne.Make} {carListOne.Model} {carListOne.Year} {carListOne.Name} {carListOne.Price} ");
            }

            

        }
    }
}
