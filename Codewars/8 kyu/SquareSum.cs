public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sqrSum = 0;
    for(int i = 0;i < numbers.Length;i++){
      sqrSum += numbers[i] * numbers[i];
    }
    return sqrSum;
  }
}