using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBalanceParanthesis
{
    /// <summary>
    /// checks whether the expression is balanced parentheses or not. 
    /// @param s is string input given by user 
    /// @return boolean true if balanced else false.
    /// </summary>
    public class BalancedParentheses
    {
        
        public bool balancedParentheses(String s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (ch == '[' || ch == '(' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        return false;
                    }
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                }
                else if (ch == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{')
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
