using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIB.Model
{
    public class Sighting
    {
        public Sighting(int antenna, int strength, DateTime timestamp, int powerLevel)
        {
            Antenna = antenna;
            Strength = strength;
            Timestamp = timestamp;
            CurrentPowerLevel = powerLevel;
        }

        public int Antenna { get; }

        public int Strength { get; }

        public DateTime Timestamp { get; }

        public string TimestampTime
        {
            get => Timestamp.ToString("HH:mm:ss");
        }

        public int CurrentPowerLevel { get; }
    }
}
