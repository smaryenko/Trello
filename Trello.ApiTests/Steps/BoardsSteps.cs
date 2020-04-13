using Trello.Api;
using Trello.Helpers.Extensions;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;
using Trello.Helpers.Asserts;

namespace Trello.Steps
{
    [Binding]
    public class BoardsSteps
    {
        BoardgApi boardApi;

        public BoardsSteps()
        {
            boardApi = new BoardgApi();
        }

        [When("I create board with name (.*)")]
        public void getRoute(string name)
        {
            boardApi.CreateBoard(name);
        }

        [Then("I should get successful response")]
        public void checkResponse()
        {
            boardApi.AssertStatusCode(System.Net.HttpStatusCode.OK);
        }

        [Then("I should get following values in body:")]
        public void ThenTheResultShouldBe(Table table)
        {
            JObject responseJson = boardApi.result.TryDeserializeJson<JObject>();

            AssertHelper.AssertJson(table, responseJson);

        }
    }
}
