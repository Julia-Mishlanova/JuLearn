using System;

public static class Kata 
{
    public static string BuildString(string[] args)
    {
      return String.Format("I like {1}!",args, String.Join(", ", args));
    }
}