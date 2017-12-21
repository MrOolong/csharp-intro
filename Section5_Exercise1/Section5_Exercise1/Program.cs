using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int counter = 0;
            int divisor = 3;

            for (int i = min; i < max; i++)
            {
                if (i / divisor)
                {
                    counter++;
                }
            }

            Console.WriteLine("X amount of numbers are divisible by 3");
        }
    }
}
