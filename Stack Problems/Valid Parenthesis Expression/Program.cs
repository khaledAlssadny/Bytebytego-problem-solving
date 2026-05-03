using System;
using System.Collections.Generic;

namespace Valid_Parenthesis_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "()[]{}";
            Console.WriteLine(ValidParenthesisExpression(input));
        }

        static bool ValidParenthesisExpression(string s)
        {
            Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (pairs.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (pairs.ContainsValue(c))
                {
                    if (stack.Count == 0 || pairs[stack.Pop()] != c)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}