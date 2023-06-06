using System.Collections.Generic;

public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> iter = new List<T>(iterable);
        if (iter.Count <= 0)
        {
            return iterable;
        }
        List<T> listOfUniq = new List<T>();

        for (int i = 0; i < iter.Count - 1; i++)
        {
            if (iter[i].ToString() != iter[i + 1].ToString())
            {
                listOfUniq.Add(iter[i]);
            }
        }
        if (iter.Last().ToString() != listOfUniq.Last().ToString())
        {
            listOfUniq.Add(iter.Last());
        }
        return listOfUniq;
    }
}
