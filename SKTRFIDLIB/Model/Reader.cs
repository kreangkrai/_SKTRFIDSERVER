using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnifiedAutomation.UaBase;

namespace SKTRFIDLIB.Model
{
    public class Reader
    {
        public Reader(NodeId nodeId, string ident, string type, string name)
        {
            NodeId = nodeId;
            Ident = ident;
            Type = type;
            Name = name;
        }

        public NodeId NodeId { get; }

        public string Name { get; }

        public string Ident { get; }

        public string Type { get; }

        public int Number
        {
            get
            {
                var result = Regex.Match(Ident, @"\d+$", RegexOptions.RightToLeft);
                if (result.Success)
                {
                    return int.Parse(result.Value);
                }
                return 0;
            }
        }
    }
}
