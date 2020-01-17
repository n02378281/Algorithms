using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ValidParanthesis
    {
        public bool IsValid(string s)
        {
            Stack<char> stk = new Stack<char>();
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {

                if (s[i] == '(')
                {
                    stk.Push(')');
                }
                else if (s[i] == '{')
                {
                    stk.Push('}');
                }
                else if (s[i] == '[')
                {
                    stk.Push(']');
                }
                else if (s[i] == '}' && stk.Count > 0 && stk.Peek() == '}')
                {
                    stk.Pop();
                }
                else if (s[i] == ']' && stk.Count > 0 && stk.Peek() == ']')
                {
                    stk.Pop();
                }
                else if (s[i] == ')' && stk.Count > 0 && stk.Peek() == ')')
                {
                    stk.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stk.Count == 0 ? true : false;
        }

        public bool IsValid1(string s)
        {
            Stack<char> sign = new Stack<char>();

            foreach (var item in s.ToCharArray())
                if (item == '(')
                    sign.Push(')');
                else if (item == '[')
                    sign.Push(']');
                else if (item == '{')
                    sign.Push('}');
                else if (sign.Count == 0 || sign.Pop() != item)
                    return false;

            return sign.Count == 0
;
        }
    }
}
