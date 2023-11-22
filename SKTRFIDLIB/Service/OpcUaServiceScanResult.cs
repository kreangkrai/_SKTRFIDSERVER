using SKTRFIDLIB.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIB.Service
{
    public class OpcUaServiceScanResult
    {
        public OpcUaServiceScanResult(ObservableCollection<RfidTag> tags, string status)
        {
            Tags = tags;
            Status = status;
        }

        public ObservableCollection<RfidTag> Tags { get; }
        public string Status { get; }
    }
}
