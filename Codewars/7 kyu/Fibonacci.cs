using System.Collections.Generic;

public class Fibonacci
{
    public static int Fib(int n)
    {
            List<int> fibonacci = new List<int>() {0, 1};

            for (int i = 0; i < n; i++)
            {
                fibonacci.Add(fibonacci[i] + fibonacci[i + 1]);
            }

            for (int j = 0; j < fibonacci.Count; j++)
            {
                if (j == n) return fibonacci[j];
            }
            return 0;
    }
}