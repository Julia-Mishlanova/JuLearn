using System.Text;
using System;

public class StockList 
{

        public static string StockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        {
            var countBooks = new int[lstOf1stLetter.Length]; 

            for (int i = 0; i < lstOf1stLetter.Length; i++)
                for (int j = 0; j < lstOfArt.Length; j++)
                {
                    if (lstOfArt[j][0].ToString() == lstOf1stLetter[i])
                    {
                        var split = lstOfArt[j].Split(' ');
                        countBooks[i] += int.Parse(split[1]);
                    }
                }
            
            int countZero = 0;
            for (int i = 0; i < countBooks.Length; i++)
            {
                if (countBooks[i] == 0) countZero++;
            }

            if (countZero < lstOf1stLetter.Length)
            {
                return GetResult(countBooks, lstOf1stLetter);
            }
            return String.Empty;
            
        }

        public static string GetResult(int[] countBooks, String[] lstOf1stLetter)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < countBooks.Length; i++)
            {
                if (i == countBooks.Length - 1)
                {
                    result.Append(string.Format(" ({0} : {1})", lstOf1stLetter[i], countBooks[i]));
                    continue;
                }
                result.Append(string.Format(" ({0} : {1}) -", lstOf1stLetter[i], countBooks[i]));
            }
            return result.ToString().TrimStart(' ');
        }
}