public class Kata
{
  public static bool ContainsValue(object[] a, object x)
  {
            //object[] a = new object[] { 80, 117, 115, 104, 45, 85, 112, 115 };
            //object x = 45;
            //Check(a, x); 

            for (int i = 0; i < a.Length; i++)
            {
                if (x.Equals(a[i])) return true;
            }
            return false;
  }
}