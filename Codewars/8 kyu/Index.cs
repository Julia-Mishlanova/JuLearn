using System;
using System.Linq;

public class Kata
{
    public static double Index(int[] array, int n)
    {
        double pow = 0;
        if (array.Length <= n) return -1;
            
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == array[n]) pow = Math.Pow(array[i], n);
        }
        return pow;
    }
}