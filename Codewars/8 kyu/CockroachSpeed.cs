using System;

public class Cockroach
{
    public static int CockroachSpeed(double x)
    {
        var speed = x * 27.7778;
        int roundSpeed = (int)Math.Floor(speed);
        return roundSpeed;
    }
}