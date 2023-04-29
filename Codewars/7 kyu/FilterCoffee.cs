using System;
using System.Collections.Generic;

public class Kata
{
        public static string Search(int budget, int[] prices)
        {
            if (budget <= 0) return "";
          
            List<object> sort = GetSortList(prices);
            string result = "";
            for (int i = 0; i < sort.Count; i++)
            {
                if ((int)sort[i] <= budget) result += sort[i].ToString() + ',';
            }
            if (result.Length > 0) return result.Substring(0, result.Length - 1);
            else return "";
        }

        public static List<object> GetSortList(int[] prices)
        {
            int min = 1000;
            List<object> sortedList = new List<object>();

            while (sortedList.Count != prices.Length)
            {
                for (int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] == '~') continue;
                    if (min > prices[i]) min = prices[i];
                }

                sortedList.Add(min);

                for (int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] == min)
                    {
                        prices[i] = '~';
                        break;
                    }
                }
                min = 1000;
            }
            return sortedList;
        }
}