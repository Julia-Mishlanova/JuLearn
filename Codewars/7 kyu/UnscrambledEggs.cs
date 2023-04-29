using System;
using System.Text.RegularExpressions;

using System.Text;

public class Kata
{
  public static string UnscrambleEggs(string word)
  {
                StringBuilder sB = new StringBuilder();
                sB.Append(word);
            
                if (word.Contains("egg"))
                {
                    sB.Replace("egg", string.Empty);
                }
                return sB.ToString();
  }
}