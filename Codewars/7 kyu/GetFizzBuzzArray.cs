using System;
using System.Collections.Generic;

public class FizzBuzz
{
	public static string[] GetFizzBuzzArray(int n)
	{
            string[] num = new string[n];

            for (int i = 0; i < num.Length; i++) num[i] += i + 1;
            
            List<string> str = new List<string>();
            str.AddRange(num);

            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(str[i]) % (3 * 5) == 0) str[i] = "Fizz" + "Buzz";
                else if (int.Parse(str[i]) % 3 == 0) str[i] = "Fizz";
                else if (int.Parse(str[i]) % 5 == 0) str[i] = "Buzz";
            }
            return str.ToArray();
	}
}