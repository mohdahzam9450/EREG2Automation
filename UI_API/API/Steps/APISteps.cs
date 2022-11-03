using NUnit.Framework;
using RestSharp;
using UI_API.API.Models;
using UI_API.API.Utilities;
using TechTalk.SpecFlow;
using System.Net;

namespace UI_API.API.Steps
{

    [Binding]
    public class APISteps
    {

        public RestClient client = new RestClient("https://reqres.in/");
        public RestRequest request = new RestRequest();
        public IRestResponse<Posts> response = new RestResponse<Posts>();


        [Given(@"I perform GET operation for ""(.*)""")]
        public void GivenIPerformGETOperationFor(string url)
        {
            request = new RestRequest(url, Method.GET);
        }

        [Given(@"I perform operation for post ""(.*)""")]
        public void GivenIPerformOperationForPost(int pageNo)
        {
            request.AddUrlSegment("pageno", pageNo.ToString());
            response = client.ExecuteAsyncRequest<Posts>(request).GetAwaiter().GetResult();
        }

        [Then(@"I should see the status code OK")]
        public void ThenIShouldSeeTheStatusCodeOK()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Then(@"I should see the content type as ""(.*)""")]
        public void ThenIShouldSeeTheContentTypeAs(string contentType)
        {
            Assert.That(response.ContentType, Is.EqualTo(contentType));
        }




        [Then(@"I should see the ""(.*)"" name as ""(.*)""")]
        public void ThenIShouldSeeTheNameAs(string key, string value)
        {
            Assert.That(response.GetResponseObject(key), Is.EqualTo(value), $"The {key} is not matching");
        }

    }
}
