using Newtonsoft.Json;
using Op.Wealth.Funds.Models.RiskFreeIndex;
using Op.Wealth.Funds.Models.TimeSeries;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Op.Wealth.Funds
{
    public class RiskFree : IRiskFree
    {
        private readonly IHttpClientFactory httpClientFactory;
        private const string dateFormat = "yyyy-MM-dd";
        public RiskFree(IHttpClientFactory _httpClientFactory)
        {
            httpClientFactory = _httpClientFactory;
        }

        /// <summary>
        /// Risk-free index
        /// Returns a summary of the evolution of the risk-free index over a given period of time.
        /// </summary>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="RiskFreeIndexModel"/></returns>
        public async Task<RiskFreeIndexModel> GetRiskFreeIndexAsync(DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<RiskFreeIndexModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/risk-free-index?summarySince={since}&summaryUntil={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<RiskFreeIndexModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/risk-free-index")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Risk-free index, logarithmic return
        /// Returns a time series of logarithmic returns of the risk-free index.If since and until are not supplied, the returned time series will cover the full history of the risk-free index.
        /// </summary>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetRiskFreeIndexLogarithmicAsync(DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/risk-free-index/log-return?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/risk-free-index/log-return")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cumulative risk-free return
        /// Returns a time series of the cumulative logarithmic returns of the risk-free index.If since and until are not supplied, the returned time series will cover the full history of the risk-free index.
        /// </summary>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetRiskFreeIndexCumulativeAsync(DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/risk-free-index/cumulative-return?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/risk-free-index/cumulative-return")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
