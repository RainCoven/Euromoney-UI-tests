using BasePageObjectModel;
using OpenQA.Selenium;
using NUnit.Framework;

namespace EuromoneySeleniumTest.Pages.IFLR
{
    class CheckoutPage : BasePage
    {
        public CheckoutPage()
		{
            baseUrl = "http://www.iflr.com/Checkoutl";
            pageTitle = "Euromoney Checkout";
        }

        private IWebElement activePlan{
           get { return driver.FindElement(By.XPath("//div[@id='ctl00_MainContent_baseProduct_SubscriptionProduct_divSubscriptionPanel']/div[@class='row active']")); }
        }

        public string getSelectedPlanName()
        {
            return activePlan.FindElement(By.ClassName("subscription-option")).Text;
        }

        public void AssertCurency()
        {
            var price = activePlan.FindElement(By.TagName("h5")).Text;
            Assert.True(price.Contains("£"));
        }
    }
}
