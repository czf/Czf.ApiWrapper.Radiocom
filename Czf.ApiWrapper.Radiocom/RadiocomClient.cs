using System;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Czf.ApiWrapper.Radiocom
{
    public class RadiocomClient : IRadiocomClient
    {
        #region static/consts
        private static readonly Uri BASE_URI = new Uri("https://www.radio.com/");
        private const string STATION_RECENTLY_PLAYED_PATH = "_components/station-recently-played/instances/default.json?stationId={0}&hour={1}&dayOfWeek={2}";
        #endregion static/consts

        #region private
        private HttpClient _client;
        #endregion private

        /// <summary>
        /// API client for radio.com
        /// </summary>
        public RadiocomClient(HttpClient client)
        {
            _client = client;
        }
        /// <summary>
        /// Retrieve recently played information for a specific station.
        /// </summary>
        /// <param name="stationId">the radio.com station Id</param>
        /// <param name="hour">the hour of the station converted from its local time to UTC</param>
        /// <param name="dayOfWeek">the day of the week for the station converted from its local time to UTC</param>
        public async Task<StationRecentlyPlayedResponse> StationRecentlyPlayed(int stationId, int hour, DayOfWeek dayOfWeek  /*string category, bool ignore_resolve_media*/)
        {
            string query = string.Format(STATION_RECENTLY_PLAYED_PATH, stationId, hour, (int)dayOfWeek);

            using (HttpResponseMessage responseMessage = await _client.GetAsync(BASE_URI + query))
            {
                using (HttpContent content = responseMessage.Content)
                {

                    StationRecentlyPlayedResponse response = JsonConvert.DeserializeObject<StationRecentlyPlayedResponse>(await content.ReadAsStringAsync());
                    return response;
                }
            }
        }
    }
}
