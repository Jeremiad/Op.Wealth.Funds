using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Op.Wealth.Funds.Models
{
    public partial class GeneralErrorModel
    {
        [JsonProperty("errors")]
        public List<Error> Errors { get; set; }
    }

    public partial class Error
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
