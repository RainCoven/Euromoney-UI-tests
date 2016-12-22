using BasePageObjectModel;
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

        public IWebElement LegalMediaBlock
        {
            get { return driver.FindElement(By.XPath("//h2[contains(text(), 'Legal media')]")).GetParent(); }
        }

        public IWebElement LegalMediaLink
        {
            get { return LegalMediaBlock.FindElement(By.ClassName("read_more")); }
        }


    }
}
