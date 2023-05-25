namespace Solution 
{
    using System;

    public class Solution
    {
        public static string[] StringToArray(string str)
        {
            var wordCount = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ') wordCount++;
            }

            var result = new string[wordCount + 1];
            string buff = string.Empty;
            var j = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    result[j] = buff;
                    buff = string.Empty;
                    j++;
                    continue;
                }
                buff += str[i];
            }
            return result;
        }
    }
}