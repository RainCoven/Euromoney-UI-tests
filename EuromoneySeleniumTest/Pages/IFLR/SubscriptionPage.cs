using BasePageObjectModel;
using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.IFLR
{
    class SubscriptionPage : BasePage
    {
        public SubscriptionPage()
		{
            baseUrl = "http://www.iflr.com/Subscription-Groups.html";
        }

        public IWebElement personalSubscriptionButton
        {
            get { return driver.FindElement(By.XPath("//*[@id='content']/div/table/tbody/tr[4]/td[1]/a")); }
        }

        public IWebElement packages
        {
            get { return driver.FindElement(By.ClassName("packages")); }
        }
    }
}
