using System;
public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        int position = 0;
        object needle = "needle";

        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle) position = i;
        }
        return "found the needle at position " + position;
    }
}