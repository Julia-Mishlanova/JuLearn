namespace Code
{
  public class Unique
  {
        public static bool AllUniq(string str)
        {
            string strLow = str.ToLower();
            HashSet<char> uniq = new HashSet<char>();

            for (int i = 0; i < strLow.Length; i++)
            {
                uniq.Add(strLow[i]);
            }
            if (strLow.Length != uniq.Count) return false;
            else return true;
        }
  }
}