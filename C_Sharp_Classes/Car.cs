using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Classes
{
    public class Car
    {
       

        public Car( string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }



        public Car( string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }







    }
}
