using System;
using System.Collections.Generic;

namespace Solution 
{
    public class Kata 
    {
        public static List<Tuple<char, int>> OrderedCount(string input) 
        {
            List<Tuple<char, int>> tuples = new List<Tuple<char, int>>();
            List<char> listOfChars = new List<char>();
            List<int> listOfInts = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!listOfChars.Contains(input[i]))
                {
                    listOfChars.Add(input[i]);
                }
            }

            for (int i = 0; i < listOfChars.Count; i++)
            {
                listOfInts.Add(0);
            }

            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < listOfChars.Count; j++)
                {
                    if (input[i] == listOfChars[j])
                    {
                        listOfInts[j] += 1;
                    }
                }

            for (int i = 0; i < listOfChars.Count; i++)
            {
                tuples.Add(Tuple.Create(listOfChars[i], listOfInts[i]));
            }
            return tuples;
        }
    }
}