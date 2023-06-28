using System.Linq;
using System.Collections.Generic;

public static class Kata
{
    public static List<char> Remember(string str)
    {
        List<char> remember = new List<char>();
        List<char> set = new List<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (!set.Contains(str[i]))
            {
                set.Add(str[i]);
                continue;
            }
            remember.Add(str[i]);
        }

        List<char> result = new List<char>();
        for (int i = 0; i < remember.Count; i++)
        {
            if (!result.Contains(remember[i]))
            {
                result.Add(remember[i]);
            }
        }
        return result;
    }
}
