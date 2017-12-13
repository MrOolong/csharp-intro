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
            // Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Please enter the speed limit");
            var userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the speed of a car");
            var userInput2 = Convert.ToInt32(Console.ReadLine());

            // calculate the difference between the speed of the car and the speed limit
            int difference = (userInput2 - userInput1);

            if (userInput2 > userInput1)
            {
                Console.WriteLine(difference);
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }
    }
}
