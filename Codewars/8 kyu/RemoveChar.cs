using System;

public class Kata
{
    public static string RemoveChar(string s)
    {
            string result = s.Remove(s.Length-1).Remove(0, 1);
            return result;
    }
}