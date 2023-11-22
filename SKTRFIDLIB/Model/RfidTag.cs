using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIB.Model
{
    public class RfidTag
    {
        public RfidTag(byte[] identifer, DateTime timestamp, string codeType)
        {
            Identifer = identifer;
            Timestamp = timestamp;
            CodeType = codeType;
            Sightings = new ObservableCollection<Sighting>();
        }

        public RfidTag(byte[] identifer, DateTime timestamp, string codeType, ObservableCollection<Sighting> sightings)
        {
            Identifer = identifer;
            Timestamp = timestamp;
            CodeType = codeType;
            Sightings = sightings;
        }

        public byte[] Identifer { get; }

        public string CodeType { get; }
        public DateTime Timestamp { get; }

        public ObservableCollection<Sighting> Sightings { get; }

        public string IdentiferString
        {
            get
            {
                if (Identifer != null)
                {
                    if (CodeType.ToLower() == "string")
                    {
                        return Encoding.ASCII.GetString(Identifer);
                    }
                    else
                    {
                        return BitConverter.ToString(Identifer).Replace("-", "");
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
