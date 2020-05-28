using System;
using Newtonsoft.Json;

namespace Czf.ApiWrapper.Radiocom
{
    public class ScheduleItem
    {
        public bool Playing { get; set; }
        public string Artist { get; set; }
        public Uri Image { get; set; }
        public Uri SiteUrl { get; set; }
        [JsonProperty("start_time")]
        public DateTimeOffset StartTime { get; set; }
        public String Title { get; set; }
    }
}
