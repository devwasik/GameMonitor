using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameMonitor
{
    class TimerClass
    {

        #region Values

        private Timer t;
        private string theTime;

        #endregion


        #region Properties

        public string TheTime
        {
            get
            {
                return theTime;
            }
            set
            {
                theTime = value;
                OnTheTimeChanged(this.theTime);
            }
        }

        #endregion

        public TimerClass()
        {
            t = new Timer();
            t.Elapsed += new ElapsedEventHandler(Timer_Tick);
            t.Interval = 5000;
            t.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TheTime = DateTime.UtcNow.ToString("dd/mm/yyyy HH:mm:ss");
        }

        public delegate void TimerTickHandler(string newTime);
        public event TimerTickHandler TheTimeChanged;

        protected void OnTheTimeChanged(string newTime)
        {
            if (TheTimeChanged != null)
            {
                TheTimeChanged(newTime);
            }
        }
    }
}