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
            Console.WriteLine("There are " + countText.Length + " characters in test.txt");

            // printing indiviual word within array - now need to count it
            // Console.WriteLine(countArray[0]);

            // foreach loop to print each individual word
            foreach (string word in countArray)
            {
                System.Console.WriteLine(word);
            }
        }
    }
}
