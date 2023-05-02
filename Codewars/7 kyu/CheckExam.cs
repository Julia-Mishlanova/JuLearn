using System;

public static class Kata
{
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int sumOfScore = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2[i] == "") continue;
                if (arr2[i] != arr1[i]) sumOfScore -= 1;
                else if (arr2[i] == arr1[i]) sumOfScore += 4;
            }
            return (sumOfScore < 0) ? 0 : sumOfScore ;
        }
}