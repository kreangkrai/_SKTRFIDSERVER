﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Model
{
    public class RFIDModel
    {
        [JsonProperty("data")]
        public List<Data> Data { get; set; } = new List<Data>();
    }
    public partial class Data
    {
        [JsonProperty("Barcode")]
        public string Barcode { get; set; }

        [JsonProperty("CaneType")]
        public string CaneType { get; set; }

        [JsonProperty("TruckNumber")]
        public string TruckNumber { get; set; }
        [JsonProperty("Allergen")]
        public string Allergen { get; set; }

        [JsonProperty("FarmerName")]
        public string FarmerName { get; set; }
    }
}
