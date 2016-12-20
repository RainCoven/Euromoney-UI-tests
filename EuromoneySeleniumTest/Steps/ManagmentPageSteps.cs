using EuromoneySeleniumTest.Pages;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace EuromoneySeleniumTest.Steps
{
    [Binding]
    public class ManagmentPageSteps : BaseSteps
    {
        ManagmentPage _managmentPage;

        public ManagmentPageSteps()
        {
            _managmentPage = new ManagmentPage();
        }

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

