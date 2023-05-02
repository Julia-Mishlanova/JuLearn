using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> Solve(List<string> arr)
  {
            List<string> word = new List<string>();
            for (int i = 0; i < arr.Count; i++)
            {
                word.Add(arr[i].ToLower());
            }
            
            var key = "abcdefghijklmnopqrstuvwxyz";

            int[] ints = new int[arr.Count];
            for (int i = 0; i < word.Count; i++)
                for (int j = 0; j < word[i].Length; j++)
                {
                    if (key[j] == word[i][j])
                    {
                        ints[i] += 1;
                    }
                }
            return ints.ToList();
  }
}