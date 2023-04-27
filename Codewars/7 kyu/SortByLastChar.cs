using System;

public static class Kata
{
  public static string[] Last(string x)
  {
            string[] sort = x.Split(' ');
            bool isSorted = false;
            string buff = "";
            while (!isSorted)
                for (int i = 0; i < sort.Length - 1; i++)
                {
                    if (sort[i][sort[i].Length - 1] > sort[i + 1][sort[i + 1].Length - 1])
                    {
                        buff = sort[i + 1];
                        sort[i + 1] = sort[i];
                        sort[i] = buff;
                        isSorted = false;
                        break;
                    }
                    isSorted = true;
                }
            return sort;
  }
}