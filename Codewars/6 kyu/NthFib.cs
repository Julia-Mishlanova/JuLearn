using System.Collections.Generic;
public class Fibonacci
{
    public int NthFib(int n)
    {
        if (n == 1) return 0;
        if (n == 2) return 1;
        return NthFib(n - 2) + NthFib(n - 1);
    }
}
