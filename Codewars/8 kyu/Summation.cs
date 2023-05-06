using System;

public static class Kata 
{
    public static int Summation(int num)
    {
            var sum = 0;
            for (var i = 0; i < num; i++)
            {
                sum += i + 1;
            }
            return sum;
    }
}