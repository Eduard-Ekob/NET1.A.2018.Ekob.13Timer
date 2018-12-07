using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerWatch
{
    class Observer2
    {
        /// <summary>
        /// Output string format
        /// </summary>
        /// <param name="sender">incomming sender</param>
        /// <param name="args">message which Observer take</param>
        public void Update(object sender, MessageEventArgs args)
        {
            Console.WriteLine(sender.ToString() + " " + args.message + " " + this.ToString());
        }
    }
}
