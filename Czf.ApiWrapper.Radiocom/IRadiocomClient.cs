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
        /// <param name="dayOfWeek">the day of the week for the station using it local time</param>
        /// <example> wednesday at 10pm in pacific daylight time would use dayOfWeek = 3 and go offset seven hours so hour = 5</example>
        Task<StationRecentlyPlayedResponse> StationRecentlyPlayed(int stationId, int hour, DayOfWeek dayOfWeek  /*string category, bool ignore_resolve_media*/);
    }
}