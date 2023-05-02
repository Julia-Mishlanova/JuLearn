using System;

public class Kata
{
    public int ReverseNumber(int n)
    {
            if (n == 0) return 0;
      
            string num = n.ToString();
            string reverse = "";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == '0') continue;
                if (char.IsDigit(num[i])) reverse += num[i];
            }
            string negative = "-";
            if (n < 0) 
            {
                negative += reverse;
                return int.Parse(negative);
            }
            return int.Parse(reverse);
    }
}