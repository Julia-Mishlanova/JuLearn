using System;
using System.Collections.Generic;

public class PartList
{
    public static string[][] Partlist(string[] arr) 
    {
            var keke = new List<string[]>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                string frst = "";
                string scnd = "";
                
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i > j) frst += arr[j] + " ";
                    if (i == j) frst += arr[j] + " ";
                    if (i < j) scnd += arr[j] + " ";
                    
                }
                keke.Add(new string[2] { frst.Substring(0, frst.Length - 1), scnd.Substring(0, scnd.Length - 1) });

            }
            return keke.ToArray();
    }
}