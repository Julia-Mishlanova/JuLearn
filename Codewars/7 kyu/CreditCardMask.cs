public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
            string sharp = "";
            for (int i = 0; i < cc.Length - 4; i++)
            {
                sharp += "#";
            }
            return sharp + cc.Substring(sharp.Length);
  }
}