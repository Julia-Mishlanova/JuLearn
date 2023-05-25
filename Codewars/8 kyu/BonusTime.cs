public static class Kata
{
    public static string BonusTime(int salary, bool bonus)
    {
        return bonus == true ? "$" + (salary * 10).ToString() : "$" + salary.ToString();
    }
}