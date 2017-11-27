using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width and height of an image");
            int width, height;
            //var numbers = new int[2];
            //numbers = Convert.ToInt32(Console.ReadLine(width, height));

            if ( width > height)
            {
                Console.WriteLine("The image is landscape");
            }
            else
            {
                Console.WriteLine("The image is portrait");
            }

        }
    }
}
