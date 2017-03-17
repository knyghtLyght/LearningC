using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y; //Initialazation

            x = 7;
            y = x + 3; //Assingment

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type you first anme: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            /*
            string myLastName;
            Console.Write("Type you last name: ");
            myLastName = Console.ReadLine();
            */

            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine(); //Declare and init in the same line

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName); //concatinate
            Console.ReadLine();
        }
    }
}
