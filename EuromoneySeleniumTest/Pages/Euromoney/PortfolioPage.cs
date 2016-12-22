using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class PortfolioPage : BasePage
    {
        public PortfolioPage()
		{
            url = euromoneyUrl + "our-portfolio";
            pageTitle = "Our portfolio | Euromoney Institutional Investor PLC";
        }

        public IWebElement LegalMediaLink
        {
            get { return driver.FindElement(By.XPath("/html/body/section/div[4]/div/div/div/div/div[1]/div/p[2]/a")); }
        }


    }
}
