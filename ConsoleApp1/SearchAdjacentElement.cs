using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class SearchAdjacentElement
    {
        public static bool FindElement(int[] NumArray , int searchElement)
        {
            if((NumArray == null)||(NumArray.Length == 0))
            {
                Console.WriteLine(" NumArray is Null or empty");
                return false;
            }
            int i = 0;
            while (i < NumArray.Length)
            {
                if(NumArray[i] == searchElement)
                {
                    Console.WriteLine(" found Search element{0} in poistion {1}", searchElement, i);
                    return true;
                }
               i = i + Math.Abs(NumArray[i]- searchElement);
            }
            Console.WriteLine("Didnt find element");
            return false;
        }
    }
}
