using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] alarmtable = new int[] { 10, 20, 30, 40, -1 };
            clock clock = new clock(0, alarmtable);
            clock.start();
        }
    }
}
class clock {
    private int sec;
    private int min;
    private int abselutesec;
    private int[] alarm=new int[5];
    public delegate void tinker();
    public delegate void alarmer();
    public event tinker ticker ;
    public event alarmer alarmon;
    public clock(int sec, int[] alarm)
    {
        this.sec = sec;
        this.alarm = alarm;
        alarmon += alarmstart;
        ticker += tick_tock;
}
    public void start() {
        while (true) {
            tick_tock();

        } }
    public void alarmstart() {
        Console.WriteLine("Alarm rings");
    }
    public void tick_tock() {
            Console.WriteLine(min + ":" + sec);
            foreach (int alarmsec in alarm)
            {
                if (abselutesec == alarmsec)
                {
                    alarmon();//调用alarm
                    break;
                }
            }
            this.sec++;
            this.abselutesec++;
            if (sec == 60)
            {
                this.min++;
                this.sec = 0;
            }
            System.Threading.Thread.Sleep(1000);

        }
    }
