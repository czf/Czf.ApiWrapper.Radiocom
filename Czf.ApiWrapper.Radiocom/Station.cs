using Newtonsoft.Json;

namespace Czf.ApiWrapper.Radiocom
{
    public struct Station
    {
        public string Category { get; set; }
        [JsonProperty("gmt_offset")]
        public sbyte GmtOffset { get; set; }
        public int Id { get; set; }
        public string PlayingClass { get; set; }
    }
}
