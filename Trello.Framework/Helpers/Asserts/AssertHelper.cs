using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Trello.Helpers.Asserts
{
    public class AssertHelper
    {
        public static void AssertJson(Table expectedTable, JObject actualObject)
        {
            Dictionary<string, string> testData = expectedTable.Rows.ToDictionary(r => r[0], r => r[1]);

            Assert.Multiple(() =>
            {
                foreach (KeyValuePair<string, string> data in testData)
                {
                    Assert.AreEqual(data.Value, actualObject.SelectToken(data.Key).ToString());
                }
            });
        }
    }
}
