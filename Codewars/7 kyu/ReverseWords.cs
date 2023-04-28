using System;

public static class Kata
{
        public static string ReverseWords(string str)
        {
            string buff = "";
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') buff += str[i];
                if (str[i] == ' ')
                {
                    result += GetReverseWord(" " + buff);
                    buff = "";
                }
            }
            return result + GetReverseWord(buff);
        }

        public static string GetReverseWord(string word)
        {
            string reverse = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            return reverse;
        }
}