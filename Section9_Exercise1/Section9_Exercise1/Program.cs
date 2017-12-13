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

            // Print the text within test1.txt
            Console.WriteLine("test1.txt contains the following text:");
            Console.WriteLine("\"" + countText + "\"");
            Console.WriteLine();

            // Print the number of characters within test1.txt
            Console.WriteLine("There are " + countText.Length + " characters in test1.txt");
            Console.WriteLine();

            // Print the number of words within test1.txt
            Console.WriteLine("There are " + countArray.Length + " words in test1.txt");
        }
    }
}
