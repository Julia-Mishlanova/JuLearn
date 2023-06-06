using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        public List<string> MexicanWave(string str)
        {
            List<string> wave = new List<string>();
            var letters = str.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == ' ') continue;
                
                letters[i] = char.ToUpper(letters[i]);
                wave.Add(new string(letters));
                letters[i] = char.ToLower(letters[i]);
            }
            return wave;
        }
    }
}