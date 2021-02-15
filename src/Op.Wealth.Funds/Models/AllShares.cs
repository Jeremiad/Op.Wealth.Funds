namespace Op.Wealth.Funds.Models.AllShares
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Op.Wealth.Funds.Models.CommonLink;

    public partial class AllSharesModel
    {
        [JsonProperty("payload")]
        public List<Payload> Payload { get; set; }
    }

    public class Payload
    {
        [JsonProperty("fundId")]
        public ulong FundId { get; set; }

        [JsonProperty("isin")]
        public string Isin { get; set; }

        [JsonProperty("shareClass")]
        public char ShareClass { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }
    }
}
