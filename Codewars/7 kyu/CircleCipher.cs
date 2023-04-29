using System.Collections.Generic;

public class Kata 
{
  
        public static string Encode(string s)
        {
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }
            
            List<char> listOfRawChar = new List<char>();
            for (int i = 0; i < reverse.Length; i++)
            {
                listOfRawChar.Add(s[i]);
                listOfRawChar.Add(reverse[i]);
            }

            string combStr = string.Join("", listOfRawChar);
            string cutCombStr = combStr.Substring(0, combStr.Length / 2);

            return cutCombStr;
        }

        public static string Decode(string s)
        {
            string str = s;
            if (s.Length % 2 != 0) str += '_';
            
            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            string frstSubStr = "";
            string scndSubStr = "";
            for (int i = 0; i < reverse.Length; i++)
            {
                if (i % 2 == 0) 
                { 
                    frstSubStr += str[i];
                    scndSubStr += reverse[i];
                }
            }

            string comb = frstSubStr + scndSubStr;
            string result = "";
            foreach (var item in comb.ToString())
            {
                if (item != '_') result += item;
            }
            return result;
        }
}