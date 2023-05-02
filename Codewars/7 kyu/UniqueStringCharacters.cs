using System;
using System.Linq;
using System.Text;

public static class Kata
{
  public static string UniqueStringCharacters(string a, string b)
  {
            StringBuilder sbForA = new StringBuilder(a);
            StringBuilder sbForB = new StringBuilder(b);
            
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j]) 
                    { 
                        sbForA.Replace(a[i].ToString(), ""); 
                        sbForB.Replace(a[i].ToString(), "");
                    }
                }
            return sbForA.ToString() + sbForB.ToString();
  }
}