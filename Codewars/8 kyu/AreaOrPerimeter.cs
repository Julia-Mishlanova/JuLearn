public class MathCheck 
{
    public static int AreaOrPerimeter(int l, int w) 
    {
        // code goes here
        if (l != w) return 2 * (l + w);
        else if (l == w) return l * w;
        else return 0;
    }
}