using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIB.Service
{
    public class EventInfoArgs
    {
        public EventInfoArgs(string source, DateTime time, DateTime receiveTime, ushort severity, string message)
        {
            Source = source;
            Time = time;
            ReceiveTime = receiveTime;
            Severity = severity;
            Message = message;
        }

        public string Source { get; }

        public DateTime Time { get; }

        public DateTime ReceiveTime { get; }

        public ushort Severity { get; }

        public string Message { get; }
    }
}
