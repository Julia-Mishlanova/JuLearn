using System;
using System.Collections.Generic;

public class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int count = 0;
            for ( int i = 0; i < peopleListInOut.Count; i++) {
                count += peopleListInOut[i][0];
                count -= peopleListInOut[i][1];            
            }
            return count;
        }        
    }