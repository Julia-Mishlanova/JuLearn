public class RentalCar 
{
    public static int RentalCarCost(int d) 
    {
        if (d >= 7 && d > 3) return (40 * d) - 50;
        if (d >= 3 && d < 7) return (40 * d) - 20;
        if (d < 3) return 40 * d;

        return 0;
    }
}