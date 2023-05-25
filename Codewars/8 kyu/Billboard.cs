public class Kata
{
  public static double Billboard(string name, double price = 30) 
  {
            double finalPrise = 0;
            for (int i = 0; i < name.Length; i++) finalPrise += price;
            return finalPrise;
  }
}