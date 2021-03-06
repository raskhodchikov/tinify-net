using Newtonsoft.Json;
using Tinify.Methods.Shrink;
using Xunit;

namespace Tinify.Tests.Methods.Shrink
{
    public class ShrinkRequestTests
    {
        [Fact]
        internal static void Shrink_Request_Serialize_Valid()
        {
            var request = new ShrinkRequest("http://test_url.com");
            var json = JsonConvert.SerializeObject(request);
            Assert.Equal(@"{""source"":{""url"":""http://test_url.com""}}", json);
        }
    }
}
