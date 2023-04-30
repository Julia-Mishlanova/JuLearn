public class Kata
{
  public static string GetMiddle(string s)
  {
            int len = s.Length;
            int indOdd = (s.Length / 2);
            int indEven = (s.Length / 2) - 1;

            string strEven = "";
            string strOdd = "";

            if (len % 2 == 0)
            {
                strEven = s[indEven].ToString()+s[indEven + 1].ToString();
                return strEven;
            }
            else if (len % 2 != 0)
            {
                strOdd = s[indOdd].ToString();
                return strOdd;
            }
            return "";
  }
}