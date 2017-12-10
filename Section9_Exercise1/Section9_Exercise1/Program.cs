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
            string[] countArray = new string[] { };
            countArray = countText.Split(' ');
            Console.WriteLine(countText);
            Console.WriteLine(countText.Length);
            Console.WriteLine(countArray);



        }
    }
}
