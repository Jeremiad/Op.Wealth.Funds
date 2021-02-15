using Op.Wealth.Funds.Models.AllFunds;
using Op.Wealth.Funds.Models.Benchmark;
using Op.Wealth.Funds.Models.CommonLink;
using Op.Wealth.Funds.Models.Details;
using Op.Wealth.Funds.Models.Holdings;
using Op.Wealth.Funds.Models.TimeSeries;
using Op.Wealth.Funds.Models.TotalPosition;
using System;
using System.Threading.Tasks;

namespace Op.Wealth.Funds
{
    public interface IFunds
    {
        Task<Link> GethateoasLinks();
        Task<AllFundsModel> GetAllFundsAsync();
        Task<FundDetailsModel> GetFundDetailsAsync(uint fundId, DateTime DtSince = default, DateTime DtUntil = default);
        Task<FundHoldingsModel> GetFundHoldingsAsync(uint fundId);
        Task<FundBenchmarkModel> GetFundBenchmarkAsync(uint fundId, DateTime DtSince = default, DateTime DtUntil = default);
        Task<TimeSeriesModel> GetFundBenchmarkNavAsync(uint fundId, DateTime DtSince = default, DateTime DtUntil = default);
        Task<TimeSeriesModel> GetFundBenchmarkLogarithmicAsync(uint fundId, DateTime DtSince = default, DateTime DtUntil = default);
        Task<FundTotalPositionModel> GetFundHoldingsTP(uint fundId, DateTime DtLatestOrDate = default);
        Task<TimeSeriesModel> GetFundCumulativeTimeSeries(uint fundId, DateTime DtSince = default, DateTime DtUntil = default);
        Task<FundInstrumentsInFundOnDateModel> GetFundsInstrumentsInFundOnDate(uint fundId, DateTime DtLatestOrDate = default);
    }
}
