using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decitions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's big giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            /*
            if (userValue == "1") //== is exactly
            {
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "You won a new boat!";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                string message = "You won a new cat!";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Sorry we didn't understand";
                Console.WriteLine(message);
            }
            */
            //refactored with efficancy
            /*
            string message = "";

            if (userValue == "1") //you don't need the {} if there is only one line in the if statment
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
            {
                message = "Sorry we didn't understand. ";
                //message = message + "You Lose.";
                message += "You Lose!"; // += takes the existing value and concatantes it with the following value
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */
            string message = (userValue == "1") ? "boat" : "strand of lint"; // if userVlaue == 1 assign boat if not assign strand of lint 
            /*
            Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");
            */

            Console.WriteLine("You entered {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();
        }
    }
}
