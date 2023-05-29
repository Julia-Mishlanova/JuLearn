using System;
using System.Linq;

public class PlayPass 
{
	      public static string playPass(string s, int n)
        {
            var letters = s.ToCharArray();
            int shiftChar = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsDigit(letters[i]))
                {
                    letters[i] = GetTheEncodedNumber(letters[i]);
                    continue;
                }
                if (!char.IsLetter(letters[i])) continue;
                
                shiftChar = (byte)s[i] + n;
                if (shiftChar > 90)
                {
                    shiftChar -= 90;
                    shiftChar += 64;
                }
                letters[i] = Convert.ToChar(shiftChar); 
            }

            for (int i = 1; i < letters.Length; i += 2)
            {
                letters[i] = char.ToLower(letters[i]);
            }

            Array.Reverse(letters);
            return new string(letters);
        }

        public static char GetTheEncodedNumber(char letter)
        {
            int digit = int.Parse(letter.ToString());
            digit = 9 - digit;
            
            return char.Parse(digit.ToString());
        }
}