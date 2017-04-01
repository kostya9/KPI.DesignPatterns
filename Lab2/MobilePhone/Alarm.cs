using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2.MobilePhone
{
    class Alarm
    {
        public int Seconds { get; }

        public event EventHandler Trigger;

        protected virtual void OnTrigger()
        {
            Trigger?.Invoke(this, EventArgs.Empty);
        }

        public Alarm(int seconds)
        {
            Seconds = seconds;
        }

        private void WaitForAlarm(object started)
        {
            DateTime timeStarted = (DateTime) started;
            while (true)
            {
                if (timeStarted.AddSeconds(Seconds) > DateTime.Now)
                    continue;
                OnTrigger();
                return;
            }
        }

        public void Start()
        {
            Console.WriteLine($"The alarm is set up for {Seconds} seconds");
            var thread = new Thread(WaitForAlarm);
            thread.Start(DateTime.Now);
        }

    }
}
