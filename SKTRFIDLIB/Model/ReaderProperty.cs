using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIB.Model
{
    public class ReaderProperty
    {
        public ReaderProperty(string name, string value, string description)
        {
            Name = name;
            Value = value;
            Description = description;
        }

        public string Name { get; }

        public string Value { get; }

        public string Description { get; }
    }
}
