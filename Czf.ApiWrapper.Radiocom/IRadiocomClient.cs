using System;
using System.Threading.Tasks;

namespace Czf.ApiWrapper.Radiocom
{
    public interface IRadiocomClient 
    {
        /// <summary>
        /// Retrieve recently played information for a specific station.
        /// </summary>
        /// <param name="stationId">the radio.com station Id</param>
        /// <param name="hour">the hour of the station converted from its local time to UTC</param>
        /// <param name="dayOfWeek">the day of the week</param>
        Task<StationRecentlyPlayedResponse> StationRecentlyPlayed(int stationId, int hour, DayOfWeek dayOfWeek  /*string category, bool ignore_resolve_media*/);
    }
}