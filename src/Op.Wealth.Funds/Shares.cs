using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Op.Wealth.Funds.Models.AllShares;
using Op.Wealth.Funds.Models.ShareDetails;
using Op.Wealth.Funds.Models.TimeSeries;

namespace Op.Wealth.Funds
{
    public class Shares : IShares
    {
        private readonly IHttpClientFactory httpClientFactory;
        private const string dateFormat = "yyyy-MM-dd";
        public Shares(IHttpClientFactory _httpClientFactory)
        {
            httpClientFactory = _httpClientFactory;
        }

        /// <summary>
        /// All shares
        /// Returns basic information about all available shares.
        /// </summary>
        /// <returns>AllSharesModel</returns>
        public async Task<AllSharesModel> GetAllSharesAsync()
        {
            var httpClient = httpClientFactory.CreateClient();

            try
            {
                return JsonConvert.DeserializeObject<AllSharesModel>(
                    await httpClient.GetStringAsync("/funds/info/v1/shares/")
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Share details
        /// Returns detailed information on a single share.
        /// </summary>
        /// <param name="isin"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns>ShareDetailModel</returns>
        public async Task<ShareDetailModel> GetShareDetailsAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<ShareDetailModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}?summarySince={since}&summaryUntil={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<ShareDetailModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// NAV time series for share
        /// Returns a time series of the Net Asset Value(NAV) of a share.
        /// </summary>
        /// <param name="isin"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetShareNavAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}/nav?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}/nav")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Logarithmic return time series for share
        /// Returns a time series of the logarithmic returns of a share.
        /// </summary>
        /// <param name="isin"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetShareLogarithmicAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}/log-return?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}/log-return")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cumulative return time series for share
        /// Returns a time series of the cumulative logarithmic returns of a specific share.
        /// </summary>
        /// <param name="isin"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetShareCumulativeAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}/cumulative-return?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}/cumulative-return")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Shares outstanding time series
        /// Returns a time series displaying the shares outstanding of a security.
        /// </summary>
        /// <param name="isin"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetShareOutStandingAsync(string isin, DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}/shares-outstanding?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/shares/{isin}/shares-outstanding")
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
