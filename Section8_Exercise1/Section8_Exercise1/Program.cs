    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Please enter a few numbers separated by hypens");
            var userInput1 = Console.ReadLine();
            var userString = userInput1.Split('-');

            Console.WriteLine(userString[0]);

            

            //if (true)
            //{
            //    Console.WriteLine("Consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("Not Consecutive");
            //}
        }
    }
}
