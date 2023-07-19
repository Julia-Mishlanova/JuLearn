using System;

public class TheClockwiseSpiral
{
    public static int[,] CreateSpiral(int N)
    {
        var matrix = new int[N, N];

        int x = 0; //i
        int y = -1; //j

        int minborder = 0;
        int maxborder = N;

        var core = Math.Pow(N, 2);
        int placeholder = 1;
        int k = 0;

        while (placeholder < core)
        {
            while (y < maxborder)
            {
                y++;
                if (y == maxborder) break;

                matrix[x, y] = placeholder;
                placeholder++;
            }
            y--;

            while (x < maxborder)
            {
                x++;
                if (x == maxborder) break;

                matrix[x, y] = placeholder;
                placeholder++;
            }
            x--;

            while (y > minborder)
            {
                y--;
                if (y < minborder) break;

                matrix[x, y] = placeholder;
                placeholder++;
            }

            while (x > minborder + 1)
            {
                x--;
                if (x < minborder + 1) break;

                matrix[x, y] = placeholder;
                placeholder++;
            }

            minborder++;
            maxborder--;
        }

        if (N % 2 != 0)
        {
            matrix[x, y + 1] = placeholder;
        }

        return matrix;
    }
}
