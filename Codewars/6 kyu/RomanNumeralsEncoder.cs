using System;
using System.Collections.Generic;

public class RomanDecode
{
	    public static int Solution(string roman)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            var key = new string[] {"I", "II", "IV", "V", "VI","IX", "X", "L", "C", "D", "M"};
            var value = new int[] { 1, 2, 4, 5, 6, 9, 10, 50, 100, 500, 1000 };
            int length = roman.Length;

            for (int i = 0; i < key.Length; i++)
            {
                map.Add(key[i].ToString(), value[i]);
            }

            if (map.ContainsKey(roman)) return map[roman];
            int num = 0;
            for (int i = 1; i < roman.Length;)
            {
                int frst = 0;
                int scnd = 0;

                foreach (var item in map)
                {
                    if (item.Key == roman[i - 1].ToString())
                    {
                        frst = item.Value;
                    }
                    if (item.Key == roman[i].ToString())
                    {
                        scnd = item.Value;
                    }
                }
                if (frst >= scnd)
                {
                    if (i == length - 1) num += scnd;
                    num += frst;
                    i++;
                    continue;
                }
                if (frst < scnd)
                {
                    string rulesOfSubtract = roman[i - 1].ToString() + roman[i];
                    num += GetNum(frst, scnd, rulesOfSubtract, map);
                    i += 2;
                }
            }
            return num;
        }
        
        public static int GetNum(int frst, int scnd, string rulesOfSubtract, Dictionary<string, int> map)
        {
            foreach (var item in map)
            {
                if (item.Key == rulesOfSubtract)
                {
                    return item.Value;
                }
            }
            return scnd - frst;
        }
}