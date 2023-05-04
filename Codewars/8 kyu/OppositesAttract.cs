using System;

public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
            int a = flower1 % 2;
            int b = flower2 % 2;
            if ((a == 0) && (b != 0)) return true;
            if ((b == 0) && (a != 0)) return true;
            return false;
    }
}