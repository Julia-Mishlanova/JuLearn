public class Kata
{
  public static bool ValidatePin(string pin)
  {
            if (pin.Length != 6 && pin.Length != 4) return false;

            for (int i = 0; i < pin.Length; i++)
            {
                if (!char.IsDigit(pin[i])) return false;
            }
            return true;
  }
}