class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
        int needBullet = dragons * 2;
        return (bullets < needBullet) ? false : true ;
    }
}