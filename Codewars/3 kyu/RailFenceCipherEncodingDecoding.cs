using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RailFenceCipher
{
    public static string Encode(string s, int n)
    {
        List<List<char>> listOfRails = SplitStringIntoRails(s, n);

        StringBuilder sb = new StringBuilder();
        foreach (List<char> innerList in listOfRails)
        {
            sb.Append(string.Join("", innerList));
        }
        return sb.ToString();
    }

    public static string Decode(string s, int n)
    {
        var lengthsOfRails = GetLengthsOfRails(s, n);
        List<int> ListOfIndex = new List<int>();
        List<List<char>> listOfRails = new List<List<char>>();

        for (int i = 0; i < n; i++)
        {
            listOfRails.Add(new List<char>());
            ListOfIndex.Add(0);
        }

        int counter = 0;
        int ind = 0;
        string buff = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            if (counter == lengthsOfRails[ind])
            {
                listOfRails[ind].AddRange(buff.ToCharArray());
                buff = string.Empty;
                counter = 0;
                ind++;
            }
            buff += s[i];
            counter++;
        }
        listOfRails[ind].AddRange(buff.ToCharArray());

        StringBuilder result = new StringBuilder();
        bool increment = true;
        int j = 0;

        while (result.Length != s.Length)
        {
            result.Append(listOfRails[j][ListOfIndex[j]]);

            if (j == n - 1) increment = false;
            if (j == 0) increment = true;

            if (increment == true)
            {
                ListOfIndex[j]++;
                j++;
                continue;
            }
            ListOfIndex[j]++;
            j--;
        }
        return result.ToString();
    }

    public static List<List<char>> SplitStringIntoRails(string s, int n)
    {
        List<List<char>> listOfRails = new List<List<char>>();
        for (int i = 0; i < n; i++)
        {
            listOfRails.Add(new List<char>());
        }

        int j = 0;
        bool increment = true;

        for (int i = 0; i < s.Length; i++)
        {
            listOfRails[j].Add(s[i]);

            if (j == n - 1) increment = false;
            if (j == 0) increment = true;

            if (increment == true)
            {
                j++;
                continue;
            }
            j--;
        }
        return listOfRails;
    }

    public static List<int> GetLengthsOfRails(string s, int n)
    {
        List<List<char>> listOfRails = SplitStringIntoRails(s, n);

        List<int> lengths = new List<int>();
        foreach (var rails in listOfRails)
        {
            lengths.Add(rails.Count);
        }
        return lengths;
    }
}
