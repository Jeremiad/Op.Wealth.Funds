namespace Op.Wealth.Funds.Models.TotalPosition
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Op.Wealth.Funds.Models.CommonLink;

    public class FundTotalPositionModel
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("totalPosition")]
        public double TotalPosition { get; set; }

        [JsonProperty("_links")]
        public List<Link> Links { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }
    }

    public class Summary
    {
        [JsonProperty("types")]
        public Types Types { get; set; }

        [JsonProperty("currencies")]
        public Currencies Currencies { get; set; }

        [JsonProperty("regions")]
        public Regions Regions { get; set; }

        [JsonProperty("sectors")]
        public Sectors Sectors { get; set; }

        [JsonProperty("maturityBuckets")]
        public MaturityBuckets MaturityBuckets { get; set; }
    }

    public class Currencies
    {
        [JsonProperty("TWD")]
        public double Twd { get; set; }

        [JsonProperty("HKD")]
        public double Hkd { get; set; }

        [JsonProperty("EUR")]
        public double Eur { get; set; }

        [JsonProperty("USD")]
        public double Usd { get; set; }

        [JsonProperty("CNY")]
        public double Cny { get; set; }
    }

    public class MaturityBuckets
    {
        [JsonProperty("N/A")]
        public double NA { get; set; }

        [JsonProperty("Months0to1")]
        public double Months0To1 { get; set; }
    }

    public class Regions
    {
        [JsonProperty("N/A")]
        public double NA { get; set; }

        [JsonProperty("TW")]
        public double Tw { get; set; }

        [JsonProperty("HK")]
        public double Hk { get; set; }

        [JsonProperty("CN")]
        public double Cn { get; set; }

        [JsonProperty("US")]
        public double Us { get; set; }
    }

    public class Sectors
    {
        [JsonProperty("10")]
        public double The10 { get; set; }

        [JsonProperty("15")]
        public double The15 { get; set; }

        [JsonProperty("20")]
        public double The20 { get; set; }

        [JsonProperty("25")]
        public double The25 { get; set; }

        [JsonProperty("30")]
        public double The30 { get; set; }

        [JsonProperty("35")]
        public double The35 { get; set; }

        [JsonProperty("40")]
        public double The40 { get; set; }

        [JsonProperty("45")]
        public double The45 { get; set; }

        [JsonProperty("55")]
        public double The55 { get; set; }

        [JsonProperty("60")]
        public double The60 { get; set; }

        [JsonProperty("N/A")]
        public double NA { get; set; }
    }

    public class Types
    {
        [JsonProperty("CASH")]
        public double Cash { get; set; }

        [JsonProperty("EQ")]
        public double Eq { get; set; }
    }
}
