using NUnit.Framework;
using RestSharp;
using System.Threading;
using TechTalk.SpecFlow;
using Snapshooter.NUnit;
using Techpro_Framework.Base;
using Techpro_Framework.Utilities;
using Techpro_Framework.Model;

namespace Techpro_Framework.Steps
{

    [Binding]
    public class GetPostsSteps
    {
        private Settings _settings;
        public GetPostsSteps(Settings settings) => _settings = settings;


        [Given(@"I perform GET operation for ""(.*)""")]
        public void GivenIPerformGETOperationFor(string url)
        {
            _settings.Request = new RestRequest(url, Method.GET);
        }

        [Given(@"I perform operation for post ""(.*)""")]
        public void GivenIPerformOperationForPost(int postId)
        {
            Thread.Sleep(2000);
            _settings.Request.AddUrlSegment("postid", postId.ToString());
            _settings.Response = _settings.RestClient.ExecuteAsyncRequests<Posts>(_settings.Request).GetAwaiter().GetResult();
        }

        [Then(@"I should see the ""(.*)"" name as ""(.*)""")]
        public void ThenIShouldSeeTheNameAs(string key, string value)
        {
            //Creating a snapshot, validates 
            Snapshot.Match(_settings.Response.Content, matchOption => matchOption.IgnoreField("title"));
            Assert.That(_settings.Response.GetResponseObject(key), Is.EqualTo(value), $"The {key} is not matching");
        }

    }
}
