using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Please enter a number");
            var userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a 2nd number");
            var userInput2 = Convert.ToInt32(Console.ReadLine());

            if ( userInput1 > userInput2)
            {
                Console.WriteLine(userInput1 + " is the larger number");
            }
            else
            {
                Console.WriteLine(userInput2 + " is the larger number");
            }
        }
    }
}
