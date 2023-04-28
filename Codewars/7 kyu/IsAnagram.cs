using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static bool IsAnagram(string test, string original)
  {
            if (test.Length != original.Length) return false;

            string testLow = test.ToLower();
            string originLow = original.ToLower();

            List<char> charsOfTest = new List<char>();
            List<char> charsOfOriginal = new List<char>();

            for (int i = 0; i < test.Length; i++)
            {
                if (!charsOfTest.Contains(testLow[i])) charsOfTest.Add(testLow[i]);
                if (!charsOfOriginal.Contains(originLow[i])) charsOfOriginal.Add(originLow[i]);
            }

            charsOfTest.Sort();
            charsOfOriginal.Sort();

            string str1 = new string(charsOfTest.ToArray());
            string str2 = new string(charsOfOriginal.ToArray());

            if (str1 == str2) return true;
            else return false;
  }
}