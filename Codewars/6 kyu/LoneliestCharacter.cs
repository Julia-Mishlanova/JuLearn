using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class Kata
    {
        public static char[] LoneliestCharacter(string res)
        {
            string result = res.Trim();

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != ' ') 
                {
                    map.Add(result[i], 0);
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    map[result[i]] += Count(result, i);
                }
            }

            List<int> ints = new List<int>();
            foreach (var item in map)
            {
                ints.Add(item.Value);
            }

            List<char> chars = new List<char>();
            ints.Sort();
            int max = ints[ints.Count - 1];

            foreach (var item in map)
            {
                if (item.Value == max)
                {
                    chars.Add(item.Key);
                }
                    
            }

            return chars.ToArray();
        }

        public static int Count(string result, int i)
        {
            int count = 0;
            for (int j = i - 1; j >= 0; j--)
            {
                if (result[j] == ' ')
                {
                    count++;
                }
                if (result[j] != ' ')
                    break;
            }

            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[j] == ' ')
                {
                    count++;
                }
                if (result[j] != ' ')
                    break;
            }
            return count;
        }
    }
}
