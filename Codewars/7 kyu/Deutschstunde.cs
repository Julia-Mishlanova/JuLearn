using System.Collections.Generic;

public class Deutschstunde
{
  public static string DerDieDas(string wort)
  {
            string wortToLow = wort.ToLower();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var key = "aeiouäöü";
            var value = new int[] {1, 1, 1, 1, 1, 1, 1, 1 };

            for (int i = 0; i < key.Length; i++)
            {
                dict.Add(key[i].ToString(), value[i]);
            }

            int sumVowels = 0;
            for (int i = 0; i < wort.Length; i++)
            {
                if (dict.ContainsKey(wortToLow[i].ToString()))
                {
                    sumVowels += dict[wortToLow[i].ToString()];
                }
            }
            if (sumVowels < 2) return "das " + wort;
            else if (sumVowels == 2 || sumVowels == 3) return "die " + wort;
            else return "der " + wort;
  }
}