using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIB.Model
{
    public class ReaderEvent
    {
        public ReaderEvent(string ident, DateTime time, ushort severity, string message, RfidTag tag)
        {
            Ident = ident;
            Time = time;
            Severity = severity;
            Message = message;
            Tag = tag;
        }

        public string Ident { get; }
        public DateTime Time { get; }
        public ushort Severity { get; }
        public string Message { get; }
        public RfidTag Tag { get; }
    }
}
