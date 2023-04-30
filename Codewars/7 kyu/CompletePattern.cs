using System;
using System.Text;
using System.Linq;

public class Kata
{
  public string Pattern(int n)
  {
            if (n == 1) return "1";
            if(n < 1) return "";
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (i + 1); 
            }

            StringBuilder pattern = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    pattern.Append(string.Concat(Enumerable.Repeat(nums[i], nums[i])));
                }
                else pattern.Append(string.Concat(Enumerable.Repeat(nums[i], nums[i])) + "\n");
            }
            return pattern.ToString();
  }
}