using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class FindDuplicate
    {
        /// <summary>
        ///  Given an array that contains numbers from 1 to n-1 and exactly 1 duplicate, find that duplicate
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>        
        public static void findDuplicateFunc(int[] numArray)
        {
           if((numArray == null)|| (numArray.Length == 0))
            {
                Console.WriteLine("array is empty");
                return;
            }
           if(numArray.Length <3)
            {
                Console.WriteLine("We cant find duplicate as Array length is lesss than 3");
                return;
            }
           int Duplicate = 0;
            int sum = 0;
           for(int i = 0; i < numArray.Length; i++)
           {
                sum += numArray[i];
            }
            int nSum = ((numArray.Length -1)*(numArray.Length))/2;
           
            Duplicate = sum - nSum;
            Console.WriteLine("Found Duplciate in {0}", Duplicate);
            return;
        }
    }
}
