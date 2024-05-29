using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ToStringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToString() : converts an object to its string representation so thst it is suitable for display 

            Car car = new Car("Chevy", "Cervette", 2022, "Blue");                  // Make an object

            Console.WriteLine(car.ToString());

            Console.ReadKey();
        }
        class Car                                                   //declar a class and here Car is a class 
        {
            string make;
            string model;
            int year;
            string color;

            public Car(string make, string model, int year, string color)       //declar constractor and assign fields 
            {
                this.make = make;
                this.model = model;
                this.year = year;
                this.color = color;
            }
            public override string ToString()                                   //We need to creat override and ToString to convert return somthing 
            {
                /*
                string message = "This is a " + make + " " + model + " " + year;
                return base.ToString();
                */


                return "This is a " + make + " Which Model" + " " + model + " Making Year" + " " + year + " Color"+ " " + color;
            }
        }
    }
}
