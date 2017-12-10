using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Section9_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\dennis\Desktop\csharp-intro\Section9_Exercise2\test2.txt";

            string countText = File.ReadAllText(path);
            var countArray = countText.Split(' ');

            // Print the text within test1.txt
            Console.WriteLine("test2.txt contains the following text:");
            Console.WriteLine("\"" + countText + "\"");
            Console.WriteLine();

            // Print the number of characters within test1.txt
            Console.WriteLine("There are " + countText.Length + " total characters in test2.txt");
            Console.WriteLine();

            // Print the number of words within test1.txt
            //Console.WriteLine("There are " + countArray.Length + " words in test2.txt");

            // printing indiviual word within array - now need to count it
            // Console.WriteLine(countArray[0]);

            //foreach loop to print each individual word
            Console.WriteLine("The char length of each word in test2.txt is as follows:");
            foreach (string word in countArray)
            {
                // word.Length displays character length - use if logic to display the longest
                System.Console.WriteLine(word.Length);
            }
        }
    }
}
