using System;

public class Hamming
{
    public static int Distance(string a, string b)
    {
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) count++;
        }
        return count;
    }
}
