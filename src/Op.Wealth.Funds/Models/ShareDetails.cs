namespace Op.Wealth.Funds.Models.ShareDetails
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Op.Wealth.Funds.Models.CommonLink;

    public class ShareDetailModel
    {
        [JsonProperty("fundId")]
        public long FundId { get; set; }

        [JsonProperty("isin")]
        public string Isin { get; set; }

        [JsonProperty("shareClass")]
        public string ShareClass { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }

        [JsonProperty("returnSummary")]
        public ReturnSummary ReturnSummary { get; set; }

        [JsonProperty("salesStatus")]
        public string SalesStatus { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("documents")]
        public Documents Documents { get; set; }

        [JsonProperty("expectedReturnPerAnnum")]
        public double ExpectedReturnPerAnnum { get; set; }

        [JsonProperty("sriRiskCategory")]
        public ushort SriRiskCategory { get; set; }

        [JsonProperty("srriRiskCategory")]
        public ushort SrriRiskCategory { get; set; }

        [JsonProperty("hexCode")]
        public string HexCode { get; set; }

        [JsonProperty("complexity")]
        public string Complexity { get; set; }

        [JsonProperty("subscriptionFee")]
        public double SubscriptionFee { get; set; }

        [JsonProperty("managementFee")]
        public double ManagementFee { get; set; }

        [JsonProperty("runningCosts")]
        public double RunningCosts { get; set; }

        [JsonProperty("terNumber")]
        public double TerNumber { get; set; }

        [JsonProperty("performanceRenumeration")]
        public ushort PerformanceRenumeration { get; set; }

        [JsonProperty("fundTransactionCosts")]
        public double FundTransactionCosts { get; set; }

        [JsonProperty("instrumentsManagementCosts")]
        public double InstrumentsManagementCosts { get; set; }
    }

    public class Description
    {
        [JsonProperty("fi")]
        public string Fi { get; set; }

        [JsonProperty("sv")]
        public string Sv { get; set; }

        [JsonProperty("en")]
        public string En { get; set; }
    }

    public class Documents
    {
        [JsonProperty("brochure")]
        public Brochure Brochure { get; set; }

        [JsonProperty("rules")]
        public Brochure Rules { get; set; }
    }

    public class Brochure
    {
        [JsonProperty("fi")]
        public Uri Fi { get; set; }

        [JsonProperty("sv")]
        public Uri Sv { get; set; }
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
