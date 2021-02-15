namespace Op.Wealth.Funds.Models.CommonLink
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class FundInstrumentsInFundOnDateModel
    {
        [JsonProperty("_links")]
        public List<Link> Links { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
