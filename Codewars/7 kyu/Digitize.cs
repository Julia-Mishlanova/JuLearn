using System;
using System.Collections.Generic;

public static class Kata
{
  public static int[] Digitize(int n)
  {
            string num = n.ToString();
            List<int> listOfDigits = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                listOfDigits.Add(int.Parse(num[i].ToString()));
            }

            int[] digitArr = new int[listOfDigits.Count];
            for (int i = 0; i < digitArr.Length; i++)
            {
                digitArr[i] = listOfDigits[i];
            }
            return digitArr;
  }
}