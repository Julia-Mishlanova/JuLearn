using System;

public class Kata
{
    public static int GetAge(string inputString)
    {
        string[] str = inputString.Split(" ");
        return int.Parse(str[0]);
    } 
} 