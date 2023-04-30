using System.Collections.Generic;

public class Kata
{
  public static string Switcheroo(string x)
  {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            var key = "ab";
            var value = "ba";

            dic.Add(key[0], value[0]);
            dic.Add(key[1], value[1]);

            string result = string.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                if (dic.ContainsKey(x[i])) result += dic[x[i]];
                else result += x[i];
            }
            return result;
  }
}