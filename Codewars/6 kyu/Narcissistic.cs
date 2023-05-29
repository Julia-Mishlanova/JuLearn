using System;

public class Kata
{
    public static bool Narcissistic(int value)
    {
        string num = value.ToString();
        int pow = num.Length;

        int result = 0;
        int digit = 0;

        for (int i = 0; i < num.Length; i++)
        {
            digit = int.Parse(num[i].ToString());
            result += (int)Math.Pow(digit, pow);
        }
        return result == value;
    }
}
