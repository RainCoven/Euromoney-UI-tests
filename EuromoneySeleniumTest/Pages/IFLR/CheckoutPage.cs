using BasePageObjectModel;
using OpenQA.Selenium;
using NUnit.Framework;

namespace EuromoneySeleniumTest.Pages.IFLR
{
    class CheckoutPage : BasePage
    {
        public CheckoutPage()
		{
            url = iflrUrl + "Checkoutl";
            pageTitle = "Euromoney Checkout";
        }

        private IWebElement ActivePlan{
           get { return driver.FindElement(By.XPath("//div[@id='ctl00_MainContent_baseProduct_SubscriptionProduct_divSubscriptionPanel']/div[@class='row active']")); }
        }

        public string GetSelectedPlanName()
        {
            return ActivePlan.FindElement(By.ClassName("subscription-option")).Text;
        }

        public void AssertCurency()
        {
            var price = ActivePlan.FindElement(By.TagName("h5")).Text;
            Assert.True(price.Contains("£"));
        }
    }
}
