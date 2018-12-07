using System;
using System.Threading;

namespace TimerWatch
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
        /// CountdownTimer back counter
        /// </summary>
        /// <param name="startTime">Input starting time</param>
        /// <exception cref="ArgumentException">If starttim less thann 1 throw ArgumentException</exception>>
        public void CountdownTimer(int delayMs)
        {
            if (delayMs <= 0)
            {
                throw new ArgumentException(nameof(delayMs));
            }

            Thread.Sleep(delayMs);
            OnMessaging(new MessageEventArgs("Elapsed seconds " + delayMs / 1000));
        }
    }
}