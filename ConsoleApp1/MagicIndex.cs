using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class MagicIndex
    {
        /// <summary>
        /// A magic index in an array A[0…n-1] is defined to be an index such that A[i] = i.
        /// Given a sorted array of distinct integers, write a method to find a magic index if one exists,
        /// in an array A. FOLLOW UP: What if the values are not distinct?
        /// </summary>
        /// <param name="numberArray"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void findMagicIndex(int[] numberArray, int low, int high)
        {
            if (low > high)
                return;
            int midIndex = (low + high) / 2;
            int midValue = numberArray[midIndex];
            if (midIndex == midValue)
            {
                Console.WriteLine(" MagicIndex :{0} , MagicValue:{1}", midIndex, midValue);
                return;
            }
            if (midValue < midIndex)
            {
                findMagicIndex(numberArray, midIndex + 1, high);
            }
            else if (midValue > midIndex)
            {
                findMagicIndex(numberArray, low, midIndex - 1);
            }
        }
        /// <summary>
        ///  FOLLOW UP: What if the values are not distinct?
        /// </summary>
        /// <param name="numberArray"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static int FindMagicIndexWithDuplicates(int[] numberArray, int low, int high)
        {
            if (low > high)
                return -1;
            int midIndex = (low + high) / 2;
            int midValue = numberArray[midIndex];
            if(midIndex == midValue)
            {
                Console.WriteLine("Magic Index:{0}", midIndex);
                return midIndex;
            }

            if (midValue < midIndex)
            {
                int leftHighIndex = Math.Min(numberArray[midIndex], midIndex - 1);
                var left = FindMagicIndexWithDuplicates(numberArray, low, leftHighIndex);
                if (left >= 0)
                {
                    Console.WriteLine("Magic Index {0}", left);
                    return left;
                }

            }
            int rightStartIndex = Math.Max(numberArray[midIndex], midIndex + 1);
            return FindMagicIndexWithDuplicates(numberArray, rightStartIndex, high);
                      
        }
    }
}
 