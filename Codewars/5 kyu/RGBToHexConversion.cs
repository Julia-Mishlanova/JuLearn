using System;
using System.Collections.Generic;

public class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        int[] rgb = new int[] { r, g, b };
        string hex = string.Empty;

        for (int i = 0; i < rgb.Length; i++)
        {
            if (rgb[i] > 255) rgb[i] = 255;
            if (rgb[i] < 0) rgb[i] = 0;

            hex += Convert(rgb[i]);
        }
        return hex;
    }

    public static string Convert(int color)
    {
        var hexadecimal = new Dictionary<double, char>();
        var nums = new double[] { 10, 11, 12, 13, 14, 15 };
        var hex = "ABCDEF";

        for (int i = 0; i < hex.Length; i++)
        {
            hexadecimal.Add(nums[i], hex[i]);
        }

        string result = string.Empty;
        double interimResult = color;
        double quotient = 0;
        double remainder = 0;

        while (result.Length < 2)
        {
            quotient = Math.Truncate(interimResult / 16);
            remainder = interimResult % 16;
            interimResult = quotient;

            if (hexadecimal.ContainsKey(remainder))
            {
                result += hexadecimal[remainder];
                continue;
            }
            result += remainder.ToString();
        }
        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
