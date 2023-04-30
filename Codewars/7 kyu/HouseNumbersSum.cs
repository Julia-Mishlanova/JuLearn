namespace Codewars
{
    using System;
    
    public class Kata
    {
        public int HouseNumbersSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 0) break;
                else sum += inputArray[i];
            }
            return sum;
        }
    }
}