using System;

namespace StackNodeParenthesis.Project
{
    public static class StackParenthesis
    {
        public static bool Analize(string source)
        {
            if (string.IsNullOrEmpty(source)) return true;
            var stack = new StackClient();
            foreach (var symbol in source)
            {
                if ("{([".Contains(symbol))
                {
                    stack.Push(symbol);
                }
                if ("})]".Contains(symbol))
                {
                    if (stack.IsEmpty) return false;
                    var popedSymbol = stack.Pop();
                    if ((symbol == '}' && popedSymbol != '{') || (symbol == ']' && popedSymbol != '[')
                        || (symbol == ')' && popedSymbol != '('))
                    {
                        return false;
                    }
                }
            }

            return stack.IsEmpty;
        }
    }
}