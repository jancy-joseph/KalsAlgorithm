using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class RotatedSortedArray
    {
        public static int findPivot(int[] numArray, int low, int high)
        {
            if (low > high)
                return -1;
            if (low == high)
                return low;
            int midIndex = (low + high) / 2;
            if((numArray[midIndex]>numArray[midIndex+1] )&& (midIndex < high))
            {
                return midIndex + 1;
            }
            if ((numArray[midIndex-1] > numArray[midIndex]) && (low < midIndex))
            {
                return midIndex;
            }

            if (numArray[midIndex] >= numArray[low])
            {
                return findPivot(numArray, midIndex + 1, high);
            }
            else
            {
                return findPivot(numArray, low, midIndex - 1);
            }
        }
        public static int FindElementIndex_BinSearch(int[] numArray, int low, int high,int numToSearch)
        {
            if (low > high)
                return -1;
            int midIndex = (low + high) / 2;
            if (numArray[midIndex] == numToSearch)
            {
                return midIndex;
            }
            if(numArray[midIndex]> numToSearch)
            {
                return FindElementIndex_BinSearch(numArray, low, midIndex - 1,numToSearch);
            }
            else if(numArray[midIndex] < numToSearch)
            {
                return FindElementIndex_BinSearch(numArray, midIndex+1, high, numToSearch);
            }
            return -1;
        }
        public static int findElement(int[] numArray,int searchElement)
        {
            if((numArray == null )|| numArray.Length==0)
            {
                Console.WriteLine("Array is empty");
                return -1;
            }
            if((numArray.Length == 1)&& (numArray[0] == searchElement))
            {
                    Console.WriteLine(" Found {0} in index {1}", searchElement,0);
                    return 0;
            }
            int foundPivot = findPivot(numArray, 0, numArray.Length - 1);
            if (foundPivot == -1)
            {
                return FindElementIndex_BinSearch(numArray, 0, numArray.Length - 1, searchElement);
            }
            else if ((searchElement >= numArray[foundPivot]) && (searchElement <= numArray[numArray.Length - 1]))
            {  
                return FindElementIndex_BinSearch(numArray, foundPivot, numArray.Length - 1, searchElement);
                    
            }
            else
            {
                if((foundPivot-1) > 0)
                {
                    return FindElementIndex_BinSearch(numArray, 0, foundPivot - 1, searchElement);

                }
                else
                {
                    return FindElementIndex_BinSearch(numArray, 0, foundPivot, searchElement);

                }

            }
        }

    }
}
