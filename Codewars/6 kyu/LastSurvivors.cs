using System.Collections.Generic;
using System.Linq;

namespace Solution 
{
  class Kata 
  {
    public static string LastSurvivors(string str) 
    {
            List<char> letters = new List<char>();
            letters.AddRange(str.ToCharArray());
            letters.Sort();
            List<char> distinct = new List<char>(letters.Distinct());

            while (distinct.Count != letters.Count)
            {
                for (int i = 0; i < letters.Count - 1; i++)
                {
                    if (letters[i] == letters[i + 1])
                    {
                        int newch = letters[i] + 1;
                        letters[i] = newch > 122 ? 'a' : (char)newch;

                        letters.RemoveAt(i + 1);
                    }
                }
                letters.Sort();
                distinct = new List<char>(letters.Distinct());
            }
            return new string(letters.ToArray());
    }
  }
}