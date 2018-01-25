using System;
using System.Collections;
using System.Collections.Generic;

namespace Brackets
{
    class Program
    {
        static bool IsBalanced(string s)
        {
            Dictionary<char, char> matched = new Dictionary<char, char>();
            matched.Add(']', '[');
            matched.Add('}', '{');
            matched.Add(')', '(');

            List<char> pushElement = new List<char>();
            pushElement.Add('[');
            pushElement.Add('{');
            pushElement.Add('(');

            Stack stack = new Stack();

            foreach (char c in s)
            {
                if (pushElement.Contains(c))
                    stack.Push(c);
                else
                    if (stack.Count == 0)
                    return false;
                else if (!stack.Pop().Equals(matched[c]))
                    return false;
            }

            if (stack.Count == 0)
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsBalanced("{()}"));
            Console.WriteLine(IsBalanced("{()"));
            Console.WriteLine(IsBalanced("{()}[]"));
        }
    }
}
