using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution
{
    public static class Kata
    {
        public static string RemoveParentheses(string s)
        {
            int countOfOpenParentheses = 0;
            var sb = new StringBuilder();
            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    countOfOpenParentheses++;
                    continue;
                }
                if (ch == ')')
                {
                    countOfOpenParentheses =
                        countOfOpenParentheses <= 0 ? 0 : countOfOpenParentheses - 1;
                    continue;
                }
                if (countOfOpenParentheses > 0)
                {
                    continue;
                }
                sb.Append(ch);
            }
            return sb.ToString();
        }
    }
}
