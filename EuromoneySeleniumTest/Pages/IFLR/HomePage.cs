using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.IFLR
{
    class HomePage : BasePage
    {
        public HomePage()
		{
            baseUrl = "http://www.iflr.com/";
        }

        public IWebElement subscribeButton
        {
            get { return driver.FindElement(By.Id("ctl00_HeaderLoginOptions1_hlSubscribe")); }
        }
    }
}
