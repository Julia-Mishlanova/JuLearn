using System.Text;

public class TwoToOne 
{
  
	public static string Longest (string s1, string s2) 
   {
            StringBuilder sort = new StringBuilder(s1 + s2);

            bool isSorted = false;
            char buff = ' ';
            
            while (!isSorted)
            {
                for (int i = 0; i < sort.Length - 1; i++)
                {
                    if ((byte)sort[i] > (byte)sort[i + 1])
                    {
                        buff = sort[i+1];
                        sort[i+1] = sort[i];
                        sort[i] = buff;
                        isSorted = false;
                        break;
                    }
                    isSorted = true;
                }
            }

            string result = "";
            for (int i = 0; i < sort.Length; i++)
            {
                if (!result.Contains(sort[i])) result += sort[i];
            }
            return result;  
   }
}