using System.Collections.Generic;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        var dublicates = new HashSet<char>();
        var occurences = new HashSet<char>();

        str = str.ToLower();

        foreach (var c in str)
        {
            if (!occurences.Contains(c))
            {
                occurences.Add(c);
                continue;
            }
            dublicates.Add(c);
        }
        return dublicates.Count;
    }
}
