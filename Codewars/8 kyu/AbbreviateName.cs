public class Kata
{
  public static string AbbrevName(string name)
  {
            char whiteSpace = ' ';
            string secondCh = "";
            string firstCh = name.Substring(0, 1);          
            char[] chars = name.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                if (chars[i] == whiteSpace)
                {
                    secondCh = chars[i + 1].ToString();
                }
            }
            return firstCh.ToUpper() + "." + secondCh.ToUpper();
  }
}