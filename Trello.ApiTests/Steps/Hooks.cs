using System;
using Flurl.Http;
using TechTalk.SpecFlow;

namespace Trello.Steps
{
    [Binding]
    public static class Hooks
    {
        [BeforeTestRun]
        public static void BeforeAll()
        {
            FlurlHttp.Configure(c =>
            {
                c.AllowedHttpStatusRange = "*";
                c.Timeout = TimeSpan.FromSeconds(30);
            });
        }
    }
}
