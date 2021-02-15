using Op.Wealth.Funds.Models.AllShares;
using Op.Wealth.Funds.Models.ShareDetails;
using Op.Wealth.Funds.Models.TimeSeries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Op.Wealth.Funds
{
    public interface IShares
    {
        public Task<AllSharesModel> GetAllSharesAsync();
        public Task<ShareDetailModel> GetShareDetailsAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default);
        public Task<TimeSeriesModel> GetShareNavAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default);
        public Task<TimeSeriesModel> GetShareLogarithmicAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default);
        public Task<TimeSeriesModel> GetShareCumulativeAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default);
        public Task<TimeSeriesModel> GetShareOutStandingAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default);
    }
}
