using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class Solution
    {
        public static bool IsValid(string s)
        {
            string sb = "squareBbracket";
            string cb = "curlyBracket";
            string ob = "originBracket";

            Stack<string> bracketStack = new Stack<string>();

            char[] arrayChars = s.ToCharArray();

            foreach (var item in arrayChars)
            {
                switch(item)
                {
                    case '(':
                        bracketStack.Push(ob);
                        break;
                    case '[':
                        bracketStack.Push(sb);
                        break;
                    case '{':
                        bracketStack.Push(cb);
                        break;
                    case ')':
                        if (bracketStack.Count == 0)
                            return false;
                        if (bracketStack.Pop() == ob)
                            continue;
                        else
                            return false;
                    case '}':
                        if (bracketStack.Count == 0)
                            return false;
                        if (bracketStack.Pop() == cb)
                            continue;
                        else
                            return false;
                    case ']':
                        if (bracketStack.Count == 0)
                            return false;
                        if (bracketStack.Pop() == sb)
                            continue;
                        else
                            return false;
                }
            }
            return bracketStack.Count == 0;
        }
    }
}
