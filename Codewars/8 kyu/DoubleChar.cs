public class Kata
{
  public static string DoubleChar(string s)
  {
    string result = "";
    for(int i = 0; i < s.Length; i++)
    {
        result += new string(s[i], 2);
    }
    return result;
  }
}