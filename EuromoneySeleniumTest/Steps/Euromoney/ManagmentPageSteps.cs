using EuromoneySeleniumTest.Pages.Euromoney;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    public partial class EuromoneySteps : BaseSteps
    {
        [Given(@"I opened Management Page")]
        public void GivenIOpenedManagementPage()
        {
            _managmentPage = new ManagmentPage();
            _managmentPage.Open();
        }

        [Given(@"Managment page has corrext title")]
        public void GivenThePageTitleIs()
        {
            _managmentPage.VerifyPage();
        }

        [Given(@"first image has an URL")]
        public void GivenFirstImageHasAnURL()
        {
            var imageUrl = _managmentPage.FirstImage.GetAttribute("src");
            Assert.AreNotEqual(imageUrl, "", "Error: image URL is empty.");
        }

        [Then(@"Management team page should be opened")]
        public void ThenManagementTeamPageShouldBeOpened()
        {
            _managmentPage = new ManagmentPage();
            _managmentPage.VerifyPage();
        }


    }
}

