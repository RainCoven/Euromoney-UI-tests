using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    public partial class EuromoneySteps : BaseSteps
    {
        [Given(@"I opened Management Page")]
        public void GivenIOpenedManagementPage()
        {
            _managmentPage.Open();
        }

        [Given(@"the page title is ""(.*)""")]
        public void GivenThePageTitleIs(string pageTitle)
        {
            _managmentPage.verifyPage(pageTitle);
        }

        [Given(@"first image has an URL")]
        public void GivenFirstImageHasAnURL()
        {
            var imageUrl = _managmentPage.firstImage.GetAttribute("src");
            Assert.AreNotEqual(imageUrl, "", "Error: image URL is empty.");
        }

    }
}

