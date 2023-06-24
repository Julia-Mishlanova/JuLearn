using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int GetLengthOfMissingArray(object[][] jagged)
    {
        if (jagged == null) return 0;
        foreach (var item in jagged)
        {
            if (item == null) return 0;
        }

        List<int> listOfLength = new List<int>();
        for (int i = 0; i < jagged.Length; i++)
        {
            if (jagged[i] == null) return 0;
            if (jagged[i].Length == 0) return 0;
            listOfLength.Add(jagged[i].Length);
        }
        listOfLength.Sort();

        for (int i = 0; i < listOfLength.Count - 1; i++)
        {
            if (listOfLength[i] + 1 != listOfLength[i + 1])
            {
                return listOfLength[i] + 1;
            }
        }
        return 0;
    }
}
