using System;

public class Kata
{
  public static int DutyFree(int normPrice, int Discount, int hol)
  {
            if (Discount == 0 || hol == 0) return 0;
            decimal a = ((decimal)normPrice / 100); 
            decimal priceDiscount = a * (decimal)Discount;
            decimal result = (decimal)hol / priceDiscount;
            int roundRes = (int)Math.Floor(result);
            return roundRes;;
  }
}