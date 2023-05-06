using System.Collections.Generic;
public class Kata
{
  public static string[] FixTheMeerkat(string[] arr)
  {
            string buff = "";
            var body = new List<string>();
            body.AddRange(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    buff = body[i];
                    body[i] = body[arr.Length - 1];
                    body[arr.Length - 1] = buff;
                }
            }
            return body.ToArray();
  }
}