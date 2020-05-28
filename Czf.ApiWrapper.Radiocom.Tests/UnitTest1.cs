using System.Threading.Tasks;
using NUnit.Framework;

namespace Czf.ApiWrapper.Radiocom.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            using (RadiocomClient radiocomClient = new RadiocomClient())
            {
                var result = await radiocomClient.StationRecentlyPlayed(902, 20, DayOfWeek.Monday);
                Assert.NotNull(result);
            }
        }
    }
}