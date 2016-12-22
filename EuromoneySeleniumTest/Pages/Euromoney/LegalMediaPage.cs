using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class LegalMediaPage : BasePage
    {
        public LegalMediaPage()
		{
            url = euromoneyUrl + "our-portfolio/legal-media";
            pageTitle = "Legal media | Our portfolio | Euromoney Institutional Investor PLC";
        }

        public IWebElement IFLRLink
        {
            get { return driver.FindElement(By.XPath("//a[contains(text(), 'Visit IFLR')]")); }
        }
    }
}
