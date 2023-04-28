using System.Text;

namespace myjinxin
{
    public class Kata
    {
        public string ReverseLetter(string str)
        {
            var reverse = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(str[i])) reverse.Append(str[i]);
            }
            return reverse.ToString();
        }
    }
}