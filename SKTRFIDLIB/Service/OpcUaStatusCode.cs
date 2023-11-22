using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIB.Service
{
    public class OpcUaStatusCode
    {
        public OpcUaStatusCode(bool isGood, uint code, string name)
        {
            IsGood = isGood;
            Name = name;
            Code = code;
        }

        public bool IsGood { get; }
        public string Name { get; }
        public uint Code { get; }
    }
}
