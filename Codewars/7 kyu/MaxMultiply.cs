public class Kata
{
    public static int MaxMultiply(int divisor, int bound)
    {
            if (bound % divisor == 0) return bound;
            
            for (int i = bound - 1; i >= 0; i--)
            {
                if (i % divisor == 0) return i;
            }
            return 0;
    }
}