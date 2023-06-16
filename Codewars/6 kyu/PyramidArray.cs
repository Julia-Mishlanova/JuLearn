using System;

public class Kata
{
    public static int[][] Pyramid(int n)
    {
        int[][] jagged = new int[n][];

        for (int j = 0; j < n; j++)
        {
            jagged[j] = new int[j + 1];
        }

        for (int i = 0; i < n; i++)
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] = 1;
            }
        return jagged;
    }
}
