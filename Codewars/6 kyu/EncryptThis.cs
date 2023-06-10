using System.Collections.Generic;
using System.Text;

namespace EncryptThis
{
    public class Kata
    {
        public static string EncryptThis(string input)
        {
            if (input == "") return "";

            var words = input.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 1)
                {
                    sb.Append((byte)words[i][0] + " ");
                    continue;
                }

                if (words[i].Length == 2)
                {
                    int firstLett = (byte)words[i][0];
                    char lastLett = words[i][1];

                    sb.Append(firstLett.ToString() + lastLett + ' ');
                    continue;
                }

                sb.Append(SwapPlaces(words[i]) + " ");
            }
            return sb.ToString().Trim();
        }

        public static string SwapPlaces(string word)
        {
            var letters = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0) continue;
                letters.Add(word[i]);
            }

            char buff = ' ';

            buff = letters[letters.Count - 1];
            letters[letters.Count - 1] = letters[0];
            letters[0] = buff;

            return (byte)word[0] + new string(letters.ToArray());
        }
    }
}
