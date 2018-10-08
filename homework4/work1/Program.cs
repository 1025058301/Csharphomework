using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ClockEventArgs : EventArgs
    {
        
    }
    public delegate void ClockEventHandler(object sender, ClockEventArgs e) ;
    public class Clock
    {
    public int Hour, Minute, Second;
     public Clock(int hour,int minute,int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;


    }
    public event ClockEventHandler Clocking;
    public void DoClock()
    {
        DateTime now = DateTime.Now;
        int year = now.Year;
        int month = now.Month;
        int day = now.Day;
        DateTime set = new DateTime(year, month, day, Hour, Minute, Second);
        while (now < set)
        {
            now = DateTime.Now;

        }
         ClockEventArgs args = new ClockEventArgs();
         Clocking(this, args);
    }

    }
public class UseClock
{
    static void Main()
    {
        var clock = new Clock(17, 42, 0);
        clock.Clocking += Showtips;
        clock.DoClock();
    }
    static void Showtips(object sender,ClockEventArgs e)
    {
        Console.WriteLine("到时间了，小老弟");
        Console.ReadLine();
    }
}
