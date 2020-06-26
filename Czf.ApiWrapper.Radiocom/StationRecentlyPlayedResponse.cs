using System.Collections.Generic;

namespace Czf.ApiWrapper.Radiocom
{
    public class StationRecentlyPlayedResponse
    {
        public bool Allowed { get; set; }
        public List<ScheduleItem> Schedule{ get; set; }

        public Station Station { get; set; }

        public StationRecentlyPlayedResponse()
        {
            Schedule = new List<ScheduleItem>();
        }
    }
}
