namespace Op.Wealth.Funds.Models.Holdings
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Op.Wealth.Funds.Models.CommonLink;

    public class FundHoldingsModel
    {
        [JsonProperty("payload")]
        public List<Payload> Payload { get; set; }
    }

    public class Payload
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("totalPosition")]
        public double TotalPosition { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }
    }
}
