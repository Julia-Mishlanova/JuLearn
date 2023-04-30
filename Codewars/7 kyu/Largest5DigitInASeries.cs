using System;
using System.Collections.Generic;

public class Kata 
{
  public static int GetNumber(string str) 
  {
            int largest = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (int.Parse(str[i].ToString()) > largest)
                {
                    largest = int.Parse(str[i].ToString());
                }
            }

            List<int> largestList = new List<int>();
            for (int i = 0; i < str.Length - 4; i++)
            {
                if (int.Parse(str[i].ToString()) == largest)
                {
                    largestList.Add(int.Parse(str[i].ToString() 
                        + str[i + 1].ToString()
                        + str[i + 2].ToString() 
                        + str[i + 3].ToString() 
                        + str[i + 4].ToString()));
                }
            }

            int result = 0;
            foreach (var item in largestList)
            {
                if (item > result) result = item;
            }
            return result;
  }
}