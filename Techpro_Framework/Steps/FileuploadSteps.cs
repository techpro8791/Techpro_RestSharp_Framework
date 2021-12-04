using NUnit.Framework;
using RestSharp;
using Techpro_Framework.Base;
using TechTalk.SpecFlow;

namespace Techpro_Framework.Steps
{
    [Binding]
    class FileuploadSteps
    {

        private Settings _settings;
        public FileuploadSteps(Settings settings) => _settings = settings;


        [Given(@"I perform POST operation for ""(.*)""")]
        public void GivenIPerformPOSTOperationFor(string path)
        {
            _settings.Request = new RestRequest(path, Method.POST);
            _settings.Request.AddFile("file", @"C:\Users\karth\Downloads\Playwright_Live.jpg", "image/jpeg");

            _settings.Response = _settings.RestClient.ExecuteAsPost(_settings.Request, "POST");
        }

        [Then(@"I see the file is being uploaded with response as (.*)")]
        public void ThenISeeTheFileIsBeingUploadedWithResponseAs(string status)
        {
            Assert.That(_settings.Response.StatusCode.ToString(), Is.EqualTo(status));
        }
    }

}
