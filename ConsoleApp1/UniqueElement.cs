using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class UniqueElement
    {
        /// <summary>
        /// 1. Find the element that appears once in a sorted array where all other elements appear twice one after another. 
        /// Find that element in 0(logn) complexity.
        /// Input: arr[] = {1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8}
        /// Output: 4
        /// </summary>
        /// <param name="numberArray"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void search(int[] numberArray, int low, int high)
        {
            if (low > high)
                return;
            if(low == high){
                Console.WriteLine("Unique Element is :{0}", numberArray[low]);
                return;
            }

            int mid = (low + high) / 2;
            //if mid index is even
            if(mid % 2 == 0)
            {
                if(numberArray[mid]== numberArray[mid + 1])
                {
                    search(numberArray, mid + 2, high);
                }
                else
                {
                    search(numberArray, low, mid);
                }
            }
            else//  odd mid index
            {
               if(numberArray[mid]== numberArray[mid - 1])
                {
                    search(numberArray, mid + 1, high);
                }
                else
                {
                    search(numberArray, low, mid);
                }
            }
        }
    }
}
