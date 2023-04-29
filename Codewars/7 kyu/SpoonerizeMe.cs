using System.Text;

public static class ReadySet
{
  public static string Spoonerize(string str)
  {
            StringBuilder sB = new StringBuilder(str);
            char buff = ' ';
            for (int i = 0; i < sB.Length; i++)
            {
                if (str[i] == ' ')
                {
                    buff = sB[i + 1];
                    sB[i + 1] = sB[0];
                    sB[0] = buff;
                }
            }
            return sB.ToString();
  }
}