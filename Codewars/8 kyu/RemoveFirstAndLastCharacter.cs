using System;

public class Kata
{
    public static string Remove_char(string s)
    {
            string result = s.Remove(s.Length-1).Remove(0, 1);
            return result;
    }
}