public class Kata
{
  public static bool Solution(string str, string ending)
  {
    if(ending.Length > str.Length) return false;
    return (str.Substring((str.Length - ending.Length)) == ending) ?  true :  false;
  }
}