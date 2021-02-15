namespace Op.Wealth.Funds.Models.TimeSeries
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TimeSeriesModel
    {
        [JsonProperty("payload")]
        public List<Payload> Payload { get; set; }
    }

    public class Payload
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
