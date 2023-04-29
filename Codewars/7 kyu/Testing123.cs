using System.Collections.Generic;

public class LineNumbering 
{
    public static List<string> Number(List<string> lines) 
    {
            List<int> num = new List<int>();
            for (int i = 0; i < lines.Count; i++)
            {
                num.Add(i + 1);
            }

            List<string> result = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                result.Add(num[i] + ": " +lines[i]);
            }
            return result;
    }
}