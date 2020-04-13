using Trello.Helpers.Attributes;
using Flurl;
using Flurl.Http;
using static System.Reflection.MethodBase;

namespace Trello.Api
{
    [RelativeUrl("/boards")]
    public class BoardgApi : BaseApi
    {
        Url classUrl;

        public BoardgApi()
        {
            classUrl = BaseUrl.Clone().AppendPathSegments(GetType().GetRelativeUrlAttribute());
        }

        [RelativeUrl("/")]
        public void CreateBoard(string name)
        {
            //Arrange
            var testUrl = classUrl.Clone().AppendPathSegment(
                GetCurrentMethod().GetRelativeUrlAttribute());

            testUrl.SetQueryParam("name", name);

            //Act
            result = testUrl.PostAsync(null).Result;
        }
    }
}
