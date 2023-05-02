using System;

public static class Kata
{
        public static int PalindromeChainLength(int n)
        {
            if (IsPalindrome(n)) return 0;
          
            long digit = n;
            int step = 0;
            long num = n;

            bool isPal = false;
            while (!isPal)
            {
                num += ReverseNumber(num);

                isPal = IsPalindrome(num);
                step++;
            }
            return step;
        }

        public static long ReverseNumber(long num)
        {
            string n = num.ToString();
            string reverse = "";
            for (int i = n.Length - 1; i >= 0; i--)
            {
                reverse += n[i];
            }
            return long.Parse(reverse);
        }

        public static bool IsPalindrome(long sum)
        {
            string s = sum.ToString();
            if (s.Length % 2 != 0)
            {
                int index = (s.Length - 1) / 2;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (i == index) continue;
                    if (s[i] != s[(s.Length - 1) - i]) return false;
                }
                return true;
            }
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] != s[(s.Length - 1) - i]) return false;
                }
                return true;
            }

        }
}