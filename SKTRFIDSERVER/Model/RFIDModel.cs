using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDSERVER.Model
{
    public class RFIDModel
    {
        [JsonProperty("data")]
        public List<Data> Data { get; set; }
    }
    public partial class Data
    {
        [JsonProperty("Barcode")]
        public string Barcode { get; set; }

        [JsonProperty("CaneType")]
        public string CaneType { get; set; }

        [JsonProperty("TruckNumber")]
        public string TruckNumber { get; set; }
    }
}
