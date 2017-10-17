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

        //Overloaded constructor - used by the method to upload playtime - this doesnt need to run at a 5000 interval like the UI
        //Passed in string is just placeholder to identify this constructor
        public TimerClass(string playTimeUpload)
        {
            t = new Timer();
            t.Elapsed += new ElapsedEventHandler(Timer_Tick);
            t.Interval = 10000; //1 minute
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