using System;

public static class Kata
{
        public static int Factorial(int n)
        {
            checked
            {
                if (n == 0) return 1;
                if (n < 0 || n > 12) throw new ArgumentOutOfRangeException();
                if (n == 1) return 1;

                return n * Factorial(n - 1);
            }
        }
}