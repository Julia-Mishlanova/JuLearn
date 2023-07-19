using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        var h = Math.Truncate((decimal)seconds / 3600);
        var remainderH = seconds % 3600;
        var m = Math.Truncate((decimal)remainderH / 60);
        var remainderM = remainderH % 60;
        var s = remainderM;

        var unitOfTime = new decimal[] { h, m, s };
        var date = new string[3];

        string time = string.Empty;
        for (int i = 0; i < unitOfTime.Length; i++)
        {
            if (unitOfTime[i] < 10) time += '0';
            time += unitOfTime[i].ToString();

            date[i] = time;
            time = string.Empty;
        }
        return string.Join(":", date);
    }
}
