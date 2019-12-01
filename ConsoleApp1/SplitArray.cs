using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class SplitArray
    {/// <summary>
     /// Given an array of numbers, split the array into two where one array contains the sum of n-1
    /// numbers and the other array with all the n-1 elements.
    /// </summary>
    /// <param name="arr"></param>
        public static void SplitArrayFunc(int[] arr)
        {
            if((arr== null)|| (arr.Length == 0))
            {
                Console.WriteLine("Nothing to do here");
                return;
            }
            int low = 0;
            int high = arr.Length - 1;
            int leftSum = arr[low];
            int rightSum = arr[high];
            while (low <= high)
            {
                if (leftSum == rightSum)
                {
                    Console.WriteLine(" found the split array at index{0}", low);
                    Console.Write("Array 1: {");
                    for(int i =0; i<=low; i++)
                    {
                        Console.Write("{0},",arr[i]);
                    }
                    Console.Write("}");
                    Console.Write("Array 2: {");
                    for (int i = high; i < arr.Length; i++)
                    {
                        Console.Write("{0},",arr[i]);
                    }
                    Console.Write("}");
                    return;
                }
                else if (leftSum > rightSum)
                {
                    rightSum += arr[--high];

                }
                else if (rightSum > leftSum)
                {
                    leftSum += arr[++low];
                    
                }
                else if (leftSum != rightSum)
                {
                    if (low > 0 && high < arr.Length - 1)
                    {
                        leftSum += arr[++low];
                        rightSum += arr[--high];
                    }
                }
            }
            Console.WriteLine(" there is no such pivot point to split array");
            return;
        }
    }
}