using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class UniqueElement
    {
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
