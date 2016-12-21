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
            var driver = (IWebDriver)ScenarioContext.Current["driver"];
            var curTabsNum = driver.WindowHandles.Count;
            _homePage = new HomePage();

            driver.SwitchTo().Window(driver.WindowHandles[curTabsNum - 1]);

            Assert.True(curTabsNum > 1);
            _homePage.VerifyPage();
        }
        
        [Then(@"there should be next personal plan Options")]
        public void ThenThereShouldBeNextPersonalPlanOptions(Table table)
        {
            foreach(TableRow roe in table.Rows)
            {
                var plan = _subscriptionPage.Packages.FindElement(By.XPath("//h2[contains(text(), 'package')]"));
                Assert.True(plan.Displayed);
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
