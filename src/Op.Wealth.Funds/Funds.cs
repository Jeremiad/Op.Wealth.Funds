using Newtonsoft.Json;
using Op.Wealth.Funds.Models.AllFunds;
using Op.Wealth.Funds.Models.Benchmark;
using Op.Wealth.Funds.Models.CommonLink;
using Op.Wealth.Funds.Models.Details;
using Op.Wealth.Funds.Models.Holdings;
using Op.Wealth.Funds.Models.TimeSeries;
using Op.Wealth.Funds.Models.TotalPosition;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Op.Wealth.Funds
{
    public class Funds : IFunds
    {
        private readonly IHttpClientFactory httpClientFactory;
        private const string dateFormat = "yyyy-MM-dd";
        public Funds(IHttpClientFactory _httpClientFactory)
        {
            httpClientFactory = _httpClientFactory;
        }

        /// <summary>
        /// HATEOAS links. 
        /// Returns HATEOAS links for traversing the API.
        /// </summary>
        /// <returns>
        /// <see cref="Link"/>
        /// </returns>
        public async Task<Link> GethateoasLinks()
        {
            var httpClient = httpClientFactory.CreateClient();

            try
            {
                return JsonConvert.DeserializeObject<Link>(
                    await httpClient.GetStringAsync("/funds/info/v1/")
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// All funds
        /// Returns all of OP's funds and their basic information.
        /// </summary>
        /// <returns><see cref="AllFundsModel"/></returns>
        public async Task<AllFundsModel> GetAllFundsAsync()
        {
            var httpClient = httpClientFactory.CreateClient();

            try
            {
                return JsonConvert.DeserializeObject<AllFundsModel>(
                    await httpClient.GetStringAsync("/funds/info/v1/funds")
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fund details
        /// Returns detailed information on a single fund, identified by fundId.
        /// </summary>
        /// <param name="fundId"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="FundDetailsModel"/></returns>
        public async Task<FundDetailsModel> GetFundDetailsAsync(uint fundId, DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();

            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<FundDetailsModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/funds/{fundId}?summarySince={since}&summaryUntil={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<FundDetailsModel>(
                        await httpClient.GetStringAsync($"/funds/info/v1/funds/{fundId}")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fund holdings
        /// Returns the total position of a fund.
        /// </summary>
        /// <param name="fundId"></param>
        /// <returns><see cref="FundHoldingsModel"/></returns>
        public async Task<FundHoldingsModel> GetFundHoldingsAsync(uint fundId)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                return JsonConvert.DeserializeObject<FundHoldingsModel>(
                    await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/holdings")
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fund benchmark
        /// Returns the benchmark summary of a single fund, identified by fundId.The fund's performance can be queried since and/or up to a given date.
        /// </summary>
        /// <param name="fundId"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="FundBenchmarkModel"/></returns>
        public async Task<FundBenchmarkModel> GetFundBenchmarkAsync(uint fundId, DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<FundBenchmarkModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/benchmark?summarySince={since}&summaryUntil={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<FundBenchmarkModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/benchmark")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// NAV time series
        /// Returns a Net Asset Value(NAV) time series benchmark for a fund.If since and until are not supplied, the returned time series will cover the full history of the fund.
        /// </summary>
        /// <param name="fundId"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetFundBenchmarkNavAsync(uint fundId, DateTime DtSince = default, DateTime DtUntil = default)
        {
            var httpClient = httpClientFactory.CreateClient();
            try
            {
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/benchmark/nav?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/benchmark/nav")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        /// <summary>
        /// Logarithmic return time series
        /// Returns a logarithmic return time series benchmark for a fund.If since and until are not supplied, the returned time series will cover the full history of the fund.
        /// </summary>
        /// <param name="fundId"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetFundBenchmarkLogarithmicAsync(uint fundId, DateTime DtSince = default, DateTime DtUntil = default)
        {
            try
            {
                var httpClient = httpClientFactory.CreateClient();
                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/benchmark/log-return?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/benchmark/log-return")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Latest total position or TP on date
        /// Returns the total position of a fund on a given date, or the latest available information on the total position.
        /// </summary>
        /// <param name="fundId"></param>
        /// <param name="DtLatestOrDate"></param>
        /// <returns><see cref="FundTotalPositionModel"/></returns>
        public async Task<FundTotalPositionModel> GetFundHoldingsTP(uint fundId, DateTime DtLatestOrDate = default)
        {
            try
            {
                var httpClient = httpClientFactory.CreateClient();
                string latestOrDate = "latest";
                if (DtLatestOrDate == default)
                {
                    return JsonConvert.DeserializeObject<FundTotalPositionModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/holdings/{latestOrDate}")
                        );
                }
                else
                {
                    latestOrDate = DtLatestOrDate.ToString(dateFormat);
                    return JsonConvert.DeserializeObject<FundTotalPositionModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/holdings/{latestOrDate}")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cumulative return time series
        /// Returns the cumulative logarithmic return time series for a single fund.If since and until are not supplied, the returned time series will cover the full history of the fund.
        /// </summary>
        /// <param name="fundId"></param>
        /// <param name="DtSince"></param>
        /// <param name="DtUntil"></param>
        /// <returns><see cref="TimeSeriesModel"/></returns>
        public async Task<TimeSeriesModel> GetFundCumulativeTimeSeries(uint fundId, DateTime DtSince = default, DateTime DtUntil = default)
        {
            try
            {
                var httpClient = httpClientFactory.CreateClient();

                if (DtSince != default && DtUntil != default)
                {
                    string since = DtSince.ToString(dateFormat);
                    string until = DtUntil.ToString(dateFormat);

                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/benchmark/cumulative-return?since={since}&until={until}")
                        );
                }
                else
                {
                    return JsonConvert.DeserializeObject<TimeSeriesModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/benchmark/cumulative-return")
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Instruments in fund on date
        /// Returns a list of all instruments held in a specified fund on a given date, or the latest available instrument list for the fund.
        /// </summary>
        /// <param name="fundId"></param>
        /// <param name="DtLatestOrDate"></param>
        /// <returns><see cref="FundInstrumentsInFundOnDateModel"/></returns>
        public async Task<FundInstrumentsInFundOnDateModel> GetFundsInstrumentsInFundOnDate(uint fundId, DateTime DtLatestOrDate = default)
        {
            try
            {
                var httpClient = httpClientFactory.CreateClient();
                string latestOrDate = "latest";
                if (DtLatestOrDate == default)
                {
                    return JsonConvert.DeserializeObject<FundInstrumentsInFundOnDateModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/holdings/{latestOrDate}/instruments")
                        );
                }
                else
                {
                    latestOrDate = DtLatestOrDate.ToString(dateFormat);
                    return JsonConvert.DeserializeObject<FundInstrumentsInFundOnDateModel>(
                        await httpClient.GetStringAsync($"funds/info/v1/funds/{fundId}/holdings/{latestOrDate}/instruments")
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
