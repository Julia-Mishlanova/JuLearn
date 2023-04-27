using System.Collections.Generic;

public class NoOddities
{
    public static int[] NoOdds(int[] values) 
    {
       List<int>even=new List<int>();
         for(int i=0;i<values.Length;i++)
            {
                if(values[i]%2==0)
                {
                    even.Add(values[i]);
                }
            }
        return even.ToArray();
    }
}