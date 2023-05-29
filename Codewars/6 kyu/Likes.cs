using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
            if (name.Length == 0) return "no one likes this";
            if (name.Length == 1) return string.Format("{0} likes this", name);
            if (name.Length == 2) return string.Format("{0} and {1} like this", name[0], name[1]);
            if (name.Length == 3) return string.Format("{0}, {1} and {2} like this", name[0], name[1], name[2]);
            if (name.Length > 3) return string.Format("{0}, {1} and {2} others like this", name[0], name[1], name.Length - 2);
            
            return string.Empty;
  }
}