using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        List<int> result = new List<int>();
        int value = 0;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == 'o')
            {
                result.Add(value);
                continue;
            }
            if (data[i] == 'i')
            {
                value++;
                continue;
            }
            if (data[i] == 'd')
            {
                value--;
                continue;
            }
            if (data[i] == 's')
            {
                value *= value;
            }
        }
        return result.ToArray();
    }
}
