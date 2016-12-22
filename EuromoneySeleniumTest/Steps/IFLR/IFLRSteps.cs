using EuromoneySeleniumTest.Pages.IFLR;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Steps.IFLR
{
    [Binding]
    public class IFLRSteps
    {
        HomePage _homePage;
        SubscriptionPage _subscriptionPage;
        CheckoutPage _checkoutPage;

        [Given(@"I am on the IFLR main page")]
        public void GivenIAmOnTheIFLRMainPage()
        {
            _homePage = new HomePage();
            _homePage.Open();
        }
        
        [Given(@"I am on the IFLR Subscription page")]
        public void GivenIAmOnTheSubscriptionPage()
        {
            _subscriptionPage = new SubscriptionPage();
            _subscriptionPage.Open();
        }
        
        [When(@"I click Subscribe button")]
        public void WhenIClickSubscribeButton()
        {
            _homePage.SubscribeButton.Click();
        }
        
        [When(@"I click select personal plan button")]
        public void WhenIClickSelectPersonalPlanButton()
        {
            _subscriptionPage.PersonalSubscriptionButton.Click();
        }
        
        [Then(@"IFLR site is opened in new tab")]
        public void ThenIFLRSiteIsOpenedInNewTab()
        {
            _homePage = new HomePage();
            var curTabsNum = _homePage.GetBrowserOpenedTabsNumber();
            _homePage.SwitchToTab(curTabsNum - 1);

            Assert.True(curTabsNum > 1, "Error: trere's should be more than 1 tab opened.");
            _homePage.VerifyPage();
        }
        
        [Then(@"there should be next personal plan Options")]
        public void ThenThereShouldBeNextPersonalPlanOptions(Table table)
        {
            foreach(TableRow row in table.Rows)
            {
                var package = _subscriptionPage.GetPackageByName(row["Option"]);
                Assert.True(package.Displayed, "Error: \"" + row["Option"] + "\" aren't displayed.");
            }
        }

        [Then(@"IFLR home page has correct title")]
        public void ThenIFLRHomePageHasCorrectTitle()
        {
            _homePage.VerifyPage();
        }

        [Then(@"Subscription page should be opened")]
        public void ThenSubscriptionPageShouldBeOpened()
        {
            _subscriptionPage = new SubscriptionPage();
            _subscriptionPage.VerifyPage();
        }

        [Then(@"Checkout page should be opened")]
        public void ThenCheckoutPageShouldBeOpened()
        {
            _checkoutPage = new CheckoutPage();
            _checkoutPage.VerifyPage();
        }

        [Then(@"priices are in pounds")]
        public void ThenPriicesAreInPounds()
        {
            _checkoutPage.AssertCurency();
        }

        [Then(@"""(.*)"" package is selected by default")]
        public void ThenPackageIsSelectedByDefault(string packageName)
        {
            Assert.AreEqual(packageName, _checkoutPage.GetSelectedPlanName(), "Error: wrong default plan selected.");
        }


    }
}
