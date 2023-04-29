using System;
using System.Text;

public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
            var words = phrase.Split(' ');
            StringBuilder sB = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sB.Append(char.ToUpper(words[i][0]) + words[i].Substring(1) + " ");
            }
            return sB.ToString().Remove(sB.Length - 1);
  }
}