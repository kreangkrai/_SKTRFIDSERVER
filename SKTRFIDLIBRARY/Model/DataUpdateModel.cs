using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Model
{
    public class DataUpdateModel
    {
        [JsonProperty("data")]
        public List<DataUpdate> Data { get; set; }
    }
    public partial class DataUpdate
    {
        [JsonProperty("STATUS_DB")]
        public long StatusDb { get; set; }
    }
}
