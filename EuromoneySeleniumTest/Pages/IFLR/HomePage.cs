using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.IFLR
{
    class HomePage : BasePage
    {
        public HomePage()
		{
            baseUrl = "http://www.iflr.com/";
            pageTitle = "International Financial Law Review - Home | IFLR.com";
        }

        public IWebElement SubscribeButton
        {
            get { return driver.FindElement(By.Id("ctl00_HeaderLoginOptions1_hlSubscribe")); }
        }
    }
}
