using System;
using System.Collections.Generic;
using System.IO;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary search of words");

            Console.WriteLine("1.Binary Searching of word from wordlist");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {

                case 1:
                    string txtpath = File.ReadAllText(@"C:\Users\Kranthi\Desktop\Bridgelabz\Day16_17\BinarySearch\BinarySearch\TextFile1.txt");
                    List<string> words = new List<string>(txtpath.Split());
                    words.Sort();
                    BinarySearchWord.BinarySearch(words);
                    break;
                default:
                    Console.WriteLine("Enter the valid option!");
                    break;

            }
            Console.WriteLine("\nDo you want to continue");
        }
    }
}
