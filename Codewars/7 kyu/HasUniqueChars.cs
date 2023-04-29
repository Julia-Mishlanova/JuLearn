namespace Code
{
  public class Unique
  {
    public static bool HasUniqueChars(string str)
    {
            string strLow = str.ToLower();

            string uniq = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (!uniq.Contains(strLow[i]))  uniq += strLow[i];
            }
            if (strLow.Length != uniq.Length) return false;
            return true;
    }
  }
}