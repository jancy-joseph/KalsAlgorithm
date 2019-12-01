using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class StackMissingParanthesis
    {
        /// <summary>
        /// Find missing parenthesis in a given expression – 2 * ( 3 + 5(sasdfasdfasd)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static char findMissingParnthesis(string str)
        {
            char s = '\0';
            if((str==null)|| (str.Length==0))
            {
                Console.WriteLine("Expression is null");
                return s;
            }
            Stack<char> s1 = new Stack<char>();
            char[] strarray = str.ToCharArray();
            for(int i =0; i<strarray.Length; i++)
            {
                int val = strarray[i] - '0';
                if(val>=0 && val <= 9)
                {
                    continue;
                }
                switch (strarray[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        s1.Push(strarray[i]);
                        break;
                    case '}':
                        if (s1.Pop() != '{')
                        {
                            Console.WriteLine("need { but found {0}", strarray[i]);
                            return '{';
                        }
                        break;
                    case ']':
                        if (s1.Pop() != '[')
                        {
                            Console.WriteLine("need [ but found {0}", strarray[i]);
                            return '[';
                        }
                        break;
                    case ')':
                        if (s1.Pop() != '(')
                        {
                            Console.WriteLine("need ( but found {0}", strarray[i]);
                            return '(';
                        }
                        break;
                    default:
                        break;
                }
            }
            if (s1.Count > 0)
            {
                while (s1.Count > 0)
                {
                    Console.WriteLine("Expression doesnot have balanced parnatthesis {0}",s1.Pop());
                }
            }
            else
            {
                Console.WriteLine("Expression is complete.No missing paranthesis");
            }
            return s;
        }
    }
}
