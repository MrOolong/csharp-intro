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
            var firstWord = countArray[0];
            var firstWordLength = countArray[0].Length;

            // Print the text within test1.txt
            Console.WriteLine("test2.txt contains the following text:");
            Console.WriteLine("\"" + countText + "\"");
            Console.WriteLine();

            // Print the first word within test1.txt
            Console.WriteLine("The first word in the file is: " + firstWord);
            Console.WriteLine();

            // Print the number of characters within test1.txt
            Console.WriteLine("There are " + countText.Length + " total characters in test2.txt");
            Console.WriteLine();    

            //foreach loop to print each individual word
            Console.WriteLine("The char length of each word in test2.txt is as follows:");

                foreach (string word in countArray)
                {
                    // word.Length displays character length - use if logic to display the longest
                    System.Console.WriteLine(word.Length);
                }

            Console.WriteLine();

            // 
            for (int i = 0; i < countArray.Length; i++)
            {
                for (int j = 0; j < countArray[i].Length; j++)
                {
                    var ith = countArray[i][j];
                    var jth = countArray[i].Length;
                    if (firstWordLength > jth)
                    {
                        Console.WriteLine(countArray[i]);
                    }
                }
            }
        }
    }
}
