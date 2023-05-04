using System;
using System.Linq;
using System.Text;

namespace Solution
{
  public static class Program
  {
    public static string RepeatString(int n, string s)
    {
        string repeat = String.Concat(Enumerable.Repeat(s, n));
		    return repeat;

    }
  }
}