using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class LegalMediaPage : BasePage
    {
        public LegalMediaPage()
		{
            baseUrl = "http://www.euromoneyplc.com/our-portfolio/legal-media";
        }

        public IWebElement IFLRLink
        {
            get { return driver.FindElement(By.LinkText("Visit IFLR")); }
        }
    }
}
