using BasePageObjectModel;
using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class ManagmentPage : BasePage
    {
        public ManagmentPage()
		{
            baseUrl = "http://www.euromoneyplc.com/who-we-are/management-team";
            pageTitle = "Management team | Who we are | Euromoney Institutional Investor PLC";
        }

        public SideMenu SideMenu
        {
            get { return new SideMenu(); }
        }

        public IWebElement FirstImage
        {
            get { return driver.FindElement(By.XPath("(//img)[1]")); }
        }

    }
}
