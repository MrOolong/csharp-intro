using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which determines the speed limit and speed of a driver
            Console.WriteLine("Please enter the speed limit");
            var userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the speed of a car");
            var userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // calculate the difference between the speed of the car and the speed limit
            int difference = (userInput2 - userInput1);

            // if logic to determine if car is is going faster than the posted speed limit
            if (userInput2 > userInput1)
            {
                Console.WriteLine("That's " + difference + " miles per hour over the limit!");
                Console.WriteLine();

                int demerit = (difference / 5);
                //Console.WriteLine(demerit);

                // another if statement to determine if the driver should lose their license
                if (demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You're docked " + demerit + " demerit points");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ok");
                Console.WriteLine();
            }
        }
    }
}
