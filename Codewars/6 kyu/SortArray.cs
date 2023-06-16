using System.Collections.Generic;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        List<object> obj = new List<object>();
        foreach (var item in array)
        {
            obj.Add(item);
        }

        List<int> listOfOdd = new List<int>();
        object blankSpace = '\0';
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                listOfOdd.Add(array[i]);
                obj[i] = blankSpace;
            }
        }

        listOfOdd.Sort();
        int j = 0;
        for (int i = 0; i < obj.Count; i++)
        {
            if (obj[i] == blankSpace)
            {
                array[i] = listOfOdd[j];
                j++;
            }
        }
        return array;
    }
}
