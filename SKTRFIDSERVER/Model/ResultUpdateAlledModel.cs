using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDSERVER.Model
{
    class ResultUpdateAlledModel
    {
        [JsonProperty("data")]
        public List<Data> Data { get; set; }
    }
    public partial class Data
    {
        [JsonProperty("STATUS_DB")]
        public long StatusDb { get; set; }
    }
}
