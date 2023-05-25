using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] MergeArrays(int[] arr1, int[] arr2)
  {
            var result = new List<int>();
            var mergeArr = new List <int>();

            mergeArr.AddRange(arr1);
            mergeArr.AddRange(arr2);

            var sort = new List<int>();
            sort = mergeArr;
            sort.Sort();
            IEnumerable<int> distinct = sort.Distinct();
            result = distinct.ToList();
            return result.ToArray();
  }
}