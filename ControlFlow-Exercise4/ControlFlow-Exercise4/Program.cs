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
            int difference1 = (userInput2 % userInput1);
            int difference2 = (userInput2 / userInput1);

            if (userInput2 > userInput1)
            {
                Console.WriteLine(difference);
                Console.WriteLine(difference1);
                Console.WriteLine(difference2);

                // another if statement to determine if the driver should lose their license
                //if (demerits > 12)
                //{
                //    Console.WriteLine("License Suspended");
                //}
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }
    }
}
