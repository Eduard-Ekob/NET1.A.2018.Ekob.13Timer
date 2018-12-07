using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeManager = new TimerManager();
            var observer1 = new Observer1();
            var observer2 = new Observer2();
            timeManager.MessagingEvent += observer1.Update;
            timeManager.MessagingEvent += observer2.Update;
            timeManager.TimerSecond(20);

            Console.ReadLine();
        }
    }
}
