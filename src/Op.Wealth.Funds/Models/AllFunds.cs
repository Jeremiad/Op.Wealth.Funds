namespace Op.Wealth.Funds.Models.AllFunds
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Op.Wealth.Funds.Models.CommonLink;

    public class AllFundsModel : GeneralErrorModel
    {
        [JsonProperty("payload")]
        public List<Payload> Payload { get; set; }
    }

    public class Payload
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("fundType")]
        public string FundType { get; set; }

        [JsonProperty("inceptionDate")]
        public DateTimeOffset InceptionDate { get; set; }

        [JsonProperty("riskClass")]
        public long RiskClass { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }
    }

    public class Name
    {
        [JsonProperty("fi")]
        public string Fi { get; set; }

        [JsonProperty("sv")]
        public string Sv { get; set; }

        [JsonProperty("en")]
        public string En { get; set; }
    }
}
