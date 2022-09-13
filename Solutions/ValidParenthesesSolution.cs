using System.Collections.Generic;
using System.Linq;

namespace NeetCodeSolutions
{
    public class ValidParenthesesSolution
    {
        public static bool IsValid(string s)
        {
            if(s.Length <= 1)
            {
                return false;
            }

            var pairs = new Dictionary<char, char>()
            {
                { '}', '{' },
                { ']', '[' },
                { ')', '(' }
            };
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if(stack.Count() > 0 && pairs.ContainsKey(c) && stack.Peek() == pairs[c])
                {
                    stack.Pop();
                }
                else if(pairs.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else
                {
                    return false;
                }
            }

            return stack.Count() == 0;
        }
    }
}
