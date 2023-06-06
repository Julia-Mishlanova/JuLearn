using System.Collections.Generic;

public class Kata
{
    public static int NumberOfPairs(string[] gloves)
    {
        HashSet<string> uniqGloves = new HashSet<string>();
        foreach (var glove in gloves)
        {
            uniqGloves.Add(glove);
        }

        int countPairs = 0;
        foreach (var glove in uniqGloves)
        {
            countPairs += FoundPair(glove, gloves);
        }

        return countPairs;
    }

    public static int FoundPair(string glove, string[] gloves)
    {
        int numGlovesSameColor = 0;
        foreach (var item in gloves)
        {
            if (item == glove)
            {
                numGlovesSameColor += 1;
            }
        }
        return (numGlovesSameColor % 2 != 0)
            ? (numGlovesSameColor - 1) / 2
            : numGlovesSameColor / 2;
    }
}
