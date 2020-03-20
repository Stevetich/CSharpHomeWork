using System;

namespace ClockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.alarmButton.ClickAndSetAlarm(10, 0, 0);
            clock.startButton.ClickAndStartClock();
        }
    }

    public delegate void TickHandler(object sender, TickEventArgs args);
    public delegate void AlarmHandler(object sender, AlarmEventArgs args);

    public class TickEventArgs
    {
        public int hour { get; set; }
        public int min { get; set; }
        public int sec { get; set; }
    }

    public class AlarmEventArgs
    {
        public int hour { get; set; }
        public int min { get; set; }
        public int sec { get; set; }

    }

    public class alarmButton
    {
        public event AlarmHandler alarm;
        public void ClickAndSetAlarm(int h, int m, int s)
        {
            Console.WriteLine($"设置闹钟：{h}点{m}分{s}秒");
            AlarmEventArgs args = new AlarmEventArgs { hour = h, min = m, sec = s };

            this.alarm(this, args);
        }
    }

    public class startButton
    {
        public event TickHandler tick;

        public void ClickAndStartClock()
        {
            Console.WriteLine("闹钟启动");
            TickEventArgs args = new TickEventArgs { hour = DateTime.Now.Hour, min = DateTime.Now.Minute, sec = DateTime.Now.Second};

        }


    }

    public class Clock
    {
        public alarmButton alarmButton = new alarmButton();
        public startButton startButton = new startButton();

        public Clock()
        {
            alarmButton.alarm += alarmBtn_Click;
            startButton.tick += startBtn_Click;
        }

       
        void alarmBtn_Click (object sender, AlarmEventArgs args)
        {
            if (args.hour == DateTime.Now.Hour && args.min == DateTime.Now.Minute && args.sec == DateTime.Now.Second)
            {
                Console.WriteLine("ding ding ding~~~");
            }
        }

        void startBtn_Click(object sender, TickEventArgs args)
        {

        }

        void tick

    }


}
