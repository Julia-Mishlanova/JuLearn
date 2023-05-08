public class Kata
{
  public static string RemoveExclamationMarks(string s)
  {
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '!') result += s[i];
            }
            return result;
  }
}