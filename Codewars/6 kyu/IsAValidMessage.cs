using System;
using System.Text;
using System.Collections.Generic;

public class Kata
{
    public static bool IsAValidMessage(string message)
    {
        StringBuilder sb = new();
        string[] arr = message.Split("0123456789".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in arr)
        {
            sb.Append($"{str.Length}{str}");
        }
        return sb.ToString() == message;
    }
}