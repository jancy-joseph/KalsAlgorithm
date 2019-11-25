using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 1, 2, 4, 4, 5, 5, 6, 6 };
            UniqueElement.search(arr, 0, arr.Length - 1);
            Console.ReadKey();
        }
    }
}
