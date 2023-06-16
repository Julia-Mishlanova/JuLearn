using System;

public class Persist
{
    public static int Persistence(long n)
    {
        int count = 0;
        int buff = 0;
        string mult = n.ToString();

        while (mult.Length != 1)
        {
            for (int i = 0; i < mult.Length; i++)
            {
                if (i == 0)
                {
                    buff = int.Parse(mult[i].ToString());
                    continue;
                }
                buff *= int.Parse(mult[i].ToString());
            }
            count++;
            mult = buff.ToString();
        }
        return count;
    }
}
