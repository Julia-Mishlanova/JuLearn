using System;
using System.Collections.Generic;
using System.Text;

public class Kata
{
  public static int SquareDigits(int n)
  {
            List<int> listOfints = new List<int>();
            string numToStr = n.ToString();

            for (int i = 0; i < numToStr.Length; i++)
            {
                listOfints.Add(int.Parse(numToStr[i].ToString()));
            }

            StringBuilder sB = new StringBuilder();
            foreach (var item in listOfints)
            {
                var pow = Math.Pow(item, 2);
                sB.Append(pow.ToString());
            }
            return int.Parse(sB.ToString());
  }
}