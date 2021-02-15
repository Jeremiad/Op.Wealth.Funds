namespace Op.Wealth.Funds.Models.InstrumentsInFundOnDate
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Op.Wealth.Funds.Models.CommonLink;

    public class FundInstrumentsInFundOnDateModel
    {
        [JsonProperty("payload")]
        public List<Payload> Payload { get; set; }
    }

    public class Payload
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("isin", NullValueHandling = NullValueHandling.Ignore)]
        public string Isin { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency { get; set; }

        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string? Region { get; set; }

        [JsonProperty("sector", NullValueHandling = NullValueHandling.Ignore)]
        public uint? Sector { get; set; }

        [JsonProperty("position")]
        public double Position { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }
    }
}
