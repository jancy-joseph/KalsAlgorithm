using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class EvaluateExpression
    {    /// <summary>
         /// 8. Evaluate an expression given only single digits and only 2 operators * and +.
         /// 2*3+1
         /// 2+3*1
        /// </summary>
        /// <param name="str"></param>
        public static void EvaluateExpressionFunc(string str)
        {
            if ((str== null)||(str.Length<3))
            {
                Console.WriteLine("Nothing to do- Expression is null or empty or invalid" );
                return;
                
            }
            char[] chrarr = str.ToCharArray();
            Stack<int> s1 = new Stack<int>();
            for(int i =0; i < chrarr.Length; i++)
            {

                switch (chrarr[i])
                {
                    case '*':
                        if (s1.Count > 0)
                        {
                            int val1 = s1.Pop();
                            int val2 = chrarr[++i]-'0';
                            int result = val1 * val2;
                            s1.Push(result);
                            Console.WriteLine("Peek {0}", s1.Peek());
                        }
                        break;
                    case '+':
                        break;
                    default:
                        int val = chrarr[i] - '0';
                        if (val >= 0 && val <= 9)
                        {
                            s1.Push(val);
                        }
                        break;

                }
            }
            int resultExpression = 0;
            while (s1.Count > 0)
            {
                resultExpression += s1.Pop();

            }
            Console.WriteLine("Result of Evaluating expression {0} is {1}", str, resultExpression);
            return;
        }
    }
}
