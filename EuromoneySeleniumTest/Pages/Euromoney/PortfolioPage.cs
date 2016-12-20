using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class PortfolioPage : BasePage
    {
        public PortfolioPage()
		{
            baseUrl = "http://www.euromoneyplc.com/our-portfolio";
        }

        public IWebElement legalMediaLink
        {
            get { return driver.FindElement(By.XPath("/html/body/section/div[4]/div/div/div/div/div[1]/div/p[2]/a")); }
        }
    }
}
