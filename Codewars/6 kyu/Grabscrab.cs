using System;
using System.Collections.Generic;

public static class Kata
{
    public static List<string> Grabscrab(string anagram, List<string> dictionary)
    {
        List<string> result = new List<string>();
        string sortAnagram = Sort(anagram);
        string sortWord = string.Empty;

        for (int i = 0; i < dictionary.Count; i++)
        {
            sortWord = Sort(dictionary[i]);
            if (sortWord == sortAnagram) result.Add(dictionary[i]);
        }
        return result;
    }

    public static string Sort(string str)
    {
        var charArr = str.ToCharArray();
        bool isSort = false;
        char buff = ' ';
        while (!isSort)
        {
            for (int i = 0; i < charArr.Length - 1; i++)
            {
                if ((byte)charArr[i] > (byte)charArr[i + 1])
                {
                    buff = charArr[i + 1];
                    charArr[i + 1] = charArr[i];
                    charArr[i] = buff;
                    isSort = false;
                    break;
                }
                isSort = true;
            }
        }
        return new string(charArr);
    }
}
