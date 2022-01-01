using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sort insertionSort = new Sort();
            int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
            insertionSort.sort(arr);
            insertionSort.PrintArray(arr);
        }
    }
}
