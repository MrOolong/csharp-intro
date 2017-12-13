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
            int width, height;
            Console.WriteLine("Enter the width of the image");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image");
            height = Convert.ToInt32(Console.ReadLine());

            if ( width > height)
            {
                Console.WriteLine("The image is landscape");
            }
            else if ( height > width)
            {
                Console.WriteLine("The image is portrait");
            }
            else if (width == height)
            {
                Console.WriteLine("That's square format!");
            }
        }
    }
}
