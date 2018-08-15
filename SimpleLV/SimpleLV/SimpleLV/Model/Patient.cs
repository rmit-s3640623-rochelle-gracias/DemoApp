using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLV.Model
{
    public class Patient
    {
        [JsonProperty("DisplayName")]
        public string DisplayName { get; set; }
    }
}
