using System.Text;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
            string number = num.ToString();
            string numBuff = string.Empty;

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '0') 
                {
                    numBuff += number[i] + new string('0', number.Length - (i + 1));
                    result.Append(numBuff + " + ");
                    numBuff = string.Empty;
                }
            }
            return result.ToString().Substring(0, result.Length - 3);
    }
}