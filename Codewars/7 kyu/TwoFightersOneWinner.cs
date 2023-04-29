public class Kata 
{
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker) 
  {
            while (fighter1.Health > 0 && fighter2.Health > 0)
            {
                if (firstAttacker == fighter1.Name)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    firstAttacker = fighter2.Name;
                    continue;
                }
                fighter1.Health -= fighter2.DamagePerAttack;
                firstAttacker = fighter1.Name;
            }
            return (fighter1.Health > fighter2.Health) ? fighter1.Name : fighter2.Name;
  }
}