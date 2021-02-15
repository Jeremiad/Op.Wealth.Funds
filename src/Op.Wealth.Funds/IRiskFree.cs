using Op.Wealth.Funds.Models.RiskFreeIndex;
using Op.Wealth.Funds.Models.TimeSeries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Op.Wealth.Funds
{
    public interface IRiskFree
    {
        public Task<RiskFreeIndexModel> GetRiskFreeIndexAsync(DateTime DtSince = default, DateTime DtUntil = default);
        public Task<TimeSeriesModel> GetRiskFreeIndexLogarithmicAsync(DateTime DtSince = default, DateTime DtUntil = default);
        public Task<TimeSeriesModel> GetRiskFreeIndexCumulativeAsync(DateTime DtSince = default, DateTime DtUntil = default);
    }
}
