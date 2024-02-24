using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Coursework
{
    public class timeKeeper
    {
        private System.Windows.Forms.Timer timer;
        public static int remainingTimeInSeconds = 180;
        public event EventHandler TimeUp;
        public event EventHandler<int> TimeUpdated;

        public timeKeeper()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //if the time is up, stop the timer and invoke the TimeUp event
            if (remainingTimeInSeconds == 0)
            {
                timer.Stop();
                TimeUp.Invoke(this, EventArgs.Empty);
                return;
            }
            //otherwise, decrement the time and invoke the TimeUpdated event
            remainingTimeInSeconds--;
            TimeUpdated.Invoke(this, remainingTimeInSeconds);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
        public int GetRemainingTimeInSeconds()
        {
            return remainingTimeInSeconds;
        }
        
    }
}