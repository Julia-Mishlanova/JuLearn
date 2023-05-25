public class Number
{
    public bool IsEven(double n)
    {
        var even = n % 2 == 0 ? (true) : (false);
        return even;
    }
}