namespace Op.Wealth.Funds.Models.Details
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Op.Wealth.Funds.Models.CommonLink;

    public partial class FundDetailsModel : GeneralErrorModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public Description Name { get; set; }

        [JsonProperty("fundType")]
        public string FundType { get; set; }

        [JsonProperty("inceptionDate")]
        public DateTimeOffset InceptionDate { get; set; }

        [JsonProperty("riskClass")]
        public long RiskClass { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }

        [JsonProperty("commentaryDate")]
        public DateTimeOffset CommentaryDate { get; set; }

        [JsonProperty("commentary")]
        public Commentary Commentary { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("expectedReturnPerAnnum")]
        public string ExpectedReturnPerAnnum { get; set; }

        [JsonProperty("sriRiskCategory")]
        public long SriRiskCategory { get; set; }

        [JsonProperty("srriRiskCategory")]
        public long SrriRiskCategory { get; set; }

        [JsonProperty("shares")]
        public List<Share> Shares { get; set; }

        [JsonProperty("benchmarkSummary")]
        public BenchmarkSummary BenchmarkSummary { get; set; }

        [JsonProperty("holdingsSummary")]
        public HoldingsSummary HoldingsSummary { get; set; }
    }

    public partial class BenchmarkSummary
    {
        [JsonProperty("oneMonth")]
        public string OneMonth { get; set; }

        [JsonProperty("threeMonths")]
        public string ThreeMonths { get; set; }

        [JsonProperty("sixMonths")]
        public string SixMonths { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("oneYear")]
        public string OneYear { get; set; }

        [JsonProperty("threeYearPA")]
        public string ThreeYearPa { get; set; }

        [JsonProperty("fiveYearPA")]
        public string FiveYearPa { get; set; }

        [JsonProperty("sinceInceptionPA")]
        public string SinceInceptionPa { get; set; }

        [JsonProperty("sinceInception")]
        public string SinceInception { get; set; }
    }

    public partial class Commentary
    {
        [JsonProperty("fi")]
        public string Fi { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("fi")]
        public string Fi { get; set; }

        [JsonProperty("sv")]
        public string Sv { get; set; }

        [JsonProperty("en")]
        public string En { get; set; }
    }

    public partial class HoldingsSummary
    {
        [JsonProperty("types")]
        public Types Types { get; set; }

        [JsonProperty("currencies")]
        public Currencies Currencies { get; set; }

        [JsonProperty("regions")]
        public Dictionary<string, string> Regions { get; set; }

        [JsonProperty("sectors")]
        public Sectors Sectors { get; set; }

        [JsonProperty("maturityBuckets")]
        public MaturityBuckets MaturityBuckets { get; set; }
    }

    public partial class Currencies
    {
        [JsonProperty("CHF")]
        public string Chf { get; set; }

        [JsonProperty("MXN")]
        public string Mxn { get; set; }

        [JsonProperty("ZMW")]
        public string Zmw { get; set; }

        [JsonProperty("CLP")]
        public string Clp { get; set; }

        [JsonProperty("UGX")]
        public string Ugx { get; set; }

        [JsonProperty("ZAR")]
        public string Zar { get; set; }

        [JsonProperty("TZS")]
        public string Tzs { get; set; }

        [JsonProperty("VND")]
        public string Vnd { get; set; }

        [JsonProperty("AUD")]
        public string Aud { get; set; }

        [JsonProperty("GHS")]
        public string Ghs { get; set; }

        [JsonProperty("IDR")]
        public string Idr { get; set; }

        [JsonProperty("TRY")]
        public string Try { get; set; }

        [JsonProperty("BWP")]
        public string Bwp { get; set; }

        [JsonProperty("TWD")]
        public string Twd { get; set; }

        [JsonProperty("AED")]
        public string Aed { get; set; }

        [JsonProperty("HKD")]
        public string Hkd { get; set; }

        [JsonProperty("EUR")]
        public string Eur { get; set; }

        [JsonProperty("DKK")]
        public string Dkk { get; set; }

        [JsonProperty("MYR")]
        public string Myr { get; set; }

        [JsonProperty("CAD")]
        public string Cad { get; set; }

        [JsonProperty("MUR")]
        public string Mur { get; set; }

        [JsonProperty("NOK")]
        public string Nok { get; set; }

        [JsonProperty("XOF")]
        public string Xof { get; set; }

        [JsonProperty("RON")]
        public string Ron { get; set; }

        [JsonProperty("MAD")]
        public string Mad { get; set; }

        [JsonProperty("NGN")]
        public string Ngn { get; set; }

        [JsonProperty("PKR")]
        public string Pkr { get; set; }

        [JsonProperty("KES")]
        public string Kes { get; set; }

        [JsonProperty("SEK")]
        public string Sek { get; set; }

        [JsonProperty("QAR")]
        public string Qar { get; set; }

        [JsonProperty("INR")]
        public string Inr { get; set; }

        [JsonProperty("CNY")]
        public string Cny { get; set; }

        [JsonProperty("THB")]
        public string Thb { get; set; }

        [JsonProperty("KRW")]
        public string Krw { get; set; }

        [JsonProperty("JPY")]
        public string Jpy { get; set; }

        [JsonProperty("BDT")]
        public string Bdt { get; set; }

        [JsonProperty("PLN")]
        public string Pln { get; set; }

        [JsonProperty("GBP")]
        public string Gbp { get; set; }

        [JsonProperty("HUF")]
        public string Huf { get; set; }

        [JsonProperty("KWD")]
        public string Kwd { get; set; }

        [JsonProperty("PHP")]
        public string Php { get; set; }

        [JsonProperty("RUB")]
        public string Rub { get; set; }

        [JsonProperty("COP")]
        public string Cop { get; set; }

        [JsonProperty("USD")]
        public string Usd { get; set; }

        [JsonProperty("EGP")]
        public string Egp { get; set; }

        [JsonProperty("SGD")]
        public string Sgd { get; set; }

        [JsonProperty("PEN")]
        public string Pen { get; set; }

        [JsonProperty("NZD")]
        public string Nzd { get; set; }

        [JsonProperty("BRL")]
        public string Brl { get; set; }
    }

    public partial class MaturityBuckets
    {
        [JsonProperty("Years7to10")]
        public string Years7To10 { get; set; }

        [JsonProperty("N/A")]
        public string NA { get; set; }

        [JsonProperty("Months1to3")]
        public string Months1To3 { get; set; }

        [JsonProperty("Months9to12")]
        public string Months9To12 { get; set; }

        [JsonProperty("Months0to1")]
        public string Months0To1 { get; set; }

        [JsonProperty("Months6to9")]
        public string Months6To9 { get; set; }

        [JsonProperty("Months3to6")]
        public string Months3To6 { get; set; }

        [JsonProperty("Years5to7")]
        public string Years5To7 { get; set; }

        [JsonProperty("Years20plus")]
        public string Years20Plus { get; set; }

        [JsonProperty("Years10to20")]
        public string Years10To20 { get; set; }

        [JsonProperty("Years3to5")]
        public string Years3To5 { get; set; }

        [JsonProperty("Years1to3")]
        public string Years1To3 { get; set; }
    }

    public partial class Sectors
    {
        [JsonProperty("10")]
        public string The10 { get; set; }

        [JsonProperty("15")]
        public string The15 { get; set; }

        [JsonProperty("20")]
        public string The20 { get; set; }

        [JsonProperty("25")]
        public string The25 { get; set; }

        [JsonProperty("30")]
        public string The30 { get; set; }

        [JsonProperty("35")]
        public string The35 { get; set; }

        [JsonProperty("40")]
        public string The40 { get; set; }

        [JsonProperty("45")]
        public string The45 { get; set; }

        [JsonProperty("50")]
        public string The50 { get; set; }

        [JsonProperty("55")]
        public string The55 { get; set; }

        [JsonProperty("60")]
        public string The60 { get; set; }

        [JsonProperty("N/A")]
        public string NA { get; set; }
    }

    public partial class Types
    {
        [JsonProperty("N/A")]
        public string NA { get; set; }

        [JsonProperty("OTH")]
        public string Oth { get; set; }

        [JsonProperty("IDB")]
        public string Idb { get; set; }

        [JsonProperty("ETF")]
        public string Etf { get; set; }

        [JsonProperty("BOND")]
        public string Bond { get; set; }

        [JsonProperty("CASH")]
        public string Cash { get; set; }

        [JsonProperty("EQ")]
        public string Eq { get; set; }
    }
    public partial class Share
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
    }
}
