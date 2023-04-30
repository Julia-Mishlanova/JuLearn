using System;
using System.Text;


public class Accumul 
{
	public static String Accum(string s) 
  {
            string str = s.ToLower();
            int[] count = new int[str.Length];
            StringBuilder sB = new StringBuilder();

            for (int i = 0; i < s.Length; i++) count[i] = i;

            for (int i = 0; i < count.Length; i++)
            {
                sB.Append(str[i].ToString().ToUpper() + new string(str[i], count[i]) + '-');
            }
            return sB.ToString().Remove(sB.Length - 1);
  }
}