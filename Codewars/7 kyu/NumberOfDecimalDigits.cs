public class DecTools 
{
  public static int Digits(ulong n) 
  {
            string nToStr = n.ToString();
    
            var countDigit = 0;
            for (int i = 0; i < nToStr.Length; i++)
            {
                if (char.IsDigit(nToStr[i])) countDigit += 1;
            }
            return countDigit;
  }
}