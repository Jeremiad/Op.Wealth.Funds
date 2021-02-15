namespace Op.Wealth.Funds.Models.RiskFreeIndex
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Op.Wealth.Funds.Models.CommonLink;

    public class RiskFreeIndexModel
    {
        [JsonProperty("returnSummary")]
        public ReturnSummary ReturnSummary { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }
    }

    public class ReturnSummary
    {
        [JsonProperty("oneMonth")]
        public double OneMonth { get; set; }

        [JsonProperty("threeMonths")]
        public double ThreeMonths { get; set; }

        [JsonProperty("sixMonths")]
        public double SixMonths { get; set; }

        [JsonProperty("year")]
        public double Year { get; set; }

        [JsonProperty("oneYear")]
        public double OneYear { get; set; }

        [JsonProperty("threeYearPA")]
        public double ThreeYearPa { get; set; }

        [JsonProperty("fiveYearPA")]
        public double FiveYearPa { get; set; }

        [JsonProperty("tenYearPA")]
        public double TenYearPa { get; set; }

        [JsonProperty("sinceInceptionPA")]
        public double SinceInceptionPa { get; set; }

        [JsonProperty("sinceInception")]
        public double SinceInception { get; set; }
    }
}
