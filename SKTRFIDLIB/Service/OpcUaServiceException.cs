using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIB.Service
{
    public class OpcUaServiceException : Exception
    {
        public OpcUaServiceException()
        {
        }

        public OpcUaServiceException(string message) : base(message)
        {
        }

        public OpcUaServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
