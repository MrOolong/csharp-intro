using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Section9_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\dennis\Desktop\csharp-intro\Section9_Exercise1\test1.txt";

            string countText = File.ReadAllText(path);
            var countArray = countText.Split(' ');

            Console.WriteLine(countText);
            Console.WriteLine(countText.Length);

            // printing indiviual word within array - now need to count it
            Console.WriteLine(countArray[0]);
        }
    }
}
