using System.Text;
public class Kata
{
  public static string Smash(string[] words)
  {
            StringBuilder sB = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sB.Append( words[i] + " " );
            }
            string res = sB.ToString();
            return res.Remove(res.Length - 1);
  }
}