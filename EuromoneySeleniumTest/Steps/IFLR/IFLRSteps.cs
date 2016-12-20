using EuromoneySeleniumTest.Pages.IFLR;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

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
            _homePage.subscribeButton.Click();
        }
        
        [When(@"I click select personal plan button")]
        public void WhenIClickSelectPersonalPlanButton()
        {
            _subscriptionPage.personalSubscriptionButton.Click();
        }
        
        [Then(@"IFLR site is opened in new tab")]
        public void ThenIFLRSiteIsOpenedInNewTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"there should be next personal plan Options")]
        public void ThenThereShouldBeNextPersonalPlanOptions(Table table)
        {
            foreach(TableRow roe in table.Rows)
            {
                var plan = _subscriptionPage.packages.FindElement(By.XPath("//h2[contains(text(), 'package')]"));
                Assert.True(plan.Displayed);
            }
        }

        [Then(@"IFLR home page has correct title")]
        public void ThenIFLRHomePageHasCorrectTitle()
        {
            _homePage.verifyPage();
        }

        [Then(@"Subscription page should be opened")]
        public void ThenSubscriptionPageShouldBeOpened()
        {
            _subscriptionPage = new SubscriptionPage();
            _subscriptionPage.verifyPage();
        }

        [Then(@"Checkout page should be opened")]
        public void ThenCheckoutPageShouldBeOpened()
        {
            _checkoutPage = new CheckoutPage();
            _checkoutPage.verifyPage();
        }


    }
}
