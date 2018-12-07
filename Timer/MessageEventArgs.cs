using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerWatch
{
    public class MessageEventArgs : System.EventArgs
    {
        public string message;
        public MessageEventArgs(string message)
        {
            this.message = message ?? throw new ArgumentNullException(nameof(message));
        }
    }
}
