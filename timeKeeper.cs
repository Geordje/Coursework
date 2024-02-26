using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Coursework
{
    public class timeKeeper
    {
        private System.Windows.Forms.Timer timer;
        private static int remainingTimeInSeconds;
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
                TimeUp.Invoke(this, EventArgs.Empty);
            }
            else
            {
                remainingTimeInSeconds--;
                TimeUpdated.Invoke(this, remainingTimeInSeconds);
            }   
        }

        public void Start()
        {
            timer.Start();
            remainingTimeInSeconds = 90;
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