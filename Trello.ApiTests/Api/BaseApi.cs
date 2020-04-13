using System.Net;
using System.Net.Http;
using Trello.Helpers.Configuration;
using Flurl;
using NUnit.Framework;

namespace Trello.Api
{
    public class BaseApi
    {
        public static Url BaseUrl = ConfigurationProvider.TestsConfiguration["ApiUrl"];
        public static Url ApiKey => ConfigurationProvider.TestsConfiguration["ApiKey"];
        public static Url Token => ConfigurationProvider.TestsConfiguration["ApiToken"];
        public HttpResponseMessage result;

        public BaseApi()
        {
            BaseUrl = BaseUrl.SetQueryParam("key", ApiKey).SetQueryParam("token", Token);
        }

        public void AssertStatusCode(HttpStatusCode expectedStatus)
        {
            Assert.AreEqual(expectedStatus, result.StatusCode, "Status code is not as expected");
        }
    }
}
