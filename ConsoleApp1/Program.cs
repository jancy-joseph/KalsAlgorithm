using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] arr = { 1, 1, 2, 4, 4, 5, 5, 6, 6 };
            //UniqueElement.search(arr, 0, arr.Length - 1);

            //without duplicates
            //int[] arr = { -10, -5, 2, 2, 2, 3, 4, 7, 9, 12, 13 };
            //int[] arr = { -10, -1, 0, 3, 10, 11, 30, 50, 100 };
            //int n = arr.Length;
            //MagicIndex.findMagicIndex(arr, 0, n - 1);

            //with Duplicates - MagicIndex
            //int[] arr = { -10, -5, 2, 2, 2, 3, 4, 7, 9, 12, 13 };
            //int n = arr.Length;
            //int index = MagicIndex.FindMagicIndexWithDuplicates(arr, 0, n - 1);
            //if (index == -1)
            //    Console.WriteLine("No Magic Index");
            //else
            //    Console.WriteLine("Magic Index is : " +
            //                                    index);


            // Let us search 3 in below array 
            //int[] arr1 = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            //int[] arr1 = { 3, 4, 5, 6, 7 };
            //int[] arr1 = { 9, 0, 1, 3, 4, 5, 6, 7, 8 };
            //int[] arr1 = { 9, 10, 11, 12, 1, 2, 3, 4, 5 };
            ////int[] arr1 = { 3, 4, 1 };
            //int n = arr1.Length;
            //int key = 3;
            //int result = RotatedSortedArray.findElement(arr1, key);
            //Console.WriteLine("Found result{0}", result);

            //int[] arr = { 9, 8, 2, 6, 1, 8, 5, 3, 4, 7 };
            int[] arr = { 1, 2, 2 };
            FindDuplicate.findDuplicateFunc(arr);
            Console.ReadKey();
        }
    }
}
