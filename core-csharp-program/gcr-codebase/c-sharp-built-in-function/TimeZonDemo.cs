using System;

class TimeZonDemo{
    static void Main(){
        DateTimeOffset now = DateTimeOffset.UtcNow;

        TimeZoneInfo gmt = TimeZoneInfo.Utc;
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        Console.WriteLine("GMT Time : " + TimeZoneInfo.ConvertTime(now, gmt));
        Console.WriteLine("IST Time : " + TimeZoneInfo.ConvertTime(now, ist));
        Console.WriteLine("PST Time : " + TimeZoneInfo.ConvertTime(now, pst));
    }
}
