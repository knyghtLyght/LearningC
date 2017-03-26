using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Tesla";
            myCar.Model = "Model S";
            myCar.Year = 2017;
            myCar.Color = "Emerald";

            Car myThirdCar = new Car("Nissan", "Leaf", 2017, "Silver");

            Console.WriteLine("{0} {1} {2} {3}", myThirdCar.Make, myThirdCar.Model, myThirdCar.Year, myThirdCar.Color);

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "Model X";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            myOtherCar = null;

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            //you could load properties from a file or other source
            this.Make = "Tesla";
        }

        public Car(string make, string model, int year, string color)
        {
            //this. is not needed but may be in old code
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }
}
