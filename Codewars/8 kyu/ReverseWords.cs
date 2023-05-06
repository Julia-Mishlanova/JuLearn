using System.Text;

public class Kata
{
  public static string ReverseWords(string str)
  {
            var words = str.Split(' ');
            StringBuilder sB = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i == 0) sB.Append(words[i]);
                else sB.Append(words[i] + " ");
            }
            return sB.ToString();
  }
}