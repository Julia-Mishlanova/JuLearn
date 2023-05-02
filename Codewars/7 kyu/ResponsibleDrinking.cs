public class Drinkin
{
    public string hydrate(string drinkString)
    {
            int sumOfGlasses = 0;
            for (int i = 0; i < drinkString.Length; i++)
            {
              if (char.IsDigit(drinkString[i]))
              {
                  sumOfGlasses += int.Parse(drinkString[i].ToString());
              }
            }    
            return (sumOfGlasses <= 1) ? sumOfGlasses + " glass of water": sumOfGlasses + " glasses of water" ;
            
    }
}