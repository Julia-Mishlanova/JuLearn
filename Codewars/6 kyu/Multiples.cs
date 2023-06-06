using System.Collections.Generic;

public static class Kata
{
    public static int Solution(int value)
    {
        List<int> listOfMultiples = new List<int>();
        int gog = 0;

        while (gog != value)
        {
            if (gog % 3 == 0 || gog % 5 == 0)
            {
                listOfMultiples.Add(gog);
            }
            gog++;
        }

        int sum = 0;
        for (int i = 0; i < listOfMultiples.Count; i++)
        {
            sum += listOfMultiples[i];
        }
        return sum;
    }
}
