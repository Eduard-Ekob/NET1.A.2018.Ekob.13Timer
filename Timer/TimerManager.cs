using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    /// <summary>
    /// Time manage class
    /// </summary>
    class TimerManager
    {   
        public event EventHandler<MessageEventArgs> MessagingEvent;
        protected virtual void OnMessaging(MessageEventArgs e)
        {
            if (MessagingEvent != null) MessagingEvent(this, e);
        }

        /// <summary>
        /// Timer back counter
        /// </summary>
        /// <param name="startTime">Input starting time</param>
        /// <exception cref="ArgumentException">If starttim less thann 1 throw ArgumentException</exception>>
        public void TimerSecond (int startTime)
        {
            if (startTime <= 0)
            {
                throw new ArgumentException(nameof(startTime)); 
            }

            const int DELAYSECOND = 1000;
            while (startTime > 0)
            {
                Thread.Sleep(DELAYSECOND);
                startTime--;
                OnMessaging(new MessageEventArgs("Second " + startTime));
            }
        }
    }
}