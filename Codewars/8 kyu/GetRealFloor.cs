using System;

public static class Kata
{
    public static int GetRealFloor(int n)
    {
        if (n <= 0) return n;
        int realFloor = (n >= 14) ? n - 2 : n -1;
        return realFloor;
    }
}