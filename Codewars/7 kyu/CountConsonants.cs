using System.Collections.Generic;

public class Kata
{
  public static int ConsonantCount(string str)
  {
            var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]) || vowels.Contains(str[i])) continue;
                count++;
            }
            return count;
  }
}