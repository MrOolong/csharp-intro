using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to enter number between 1-10
            int number;
            Console.WriteLine("Enter a valid number between 1-10");
            number = Convert.ToInt32(Console.ReadLine());
            // if valid number, display "valid"
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
