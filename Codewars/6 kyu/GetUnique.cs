using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        List<int> gog = numbers.ToList();
        int notUniq = 0;

        for (int i = 0; i < gog.Count; i++)
        {
            if (gog[i] == gog[i + 1])
            {
                notUniq = gog[i];
                break;
            }
        }

        for (int i = 0; i < gog.Count; i++)
        {
            if (gog[i] != notUniq) return gog[i];
        }
        return notUniq;
    }
}
