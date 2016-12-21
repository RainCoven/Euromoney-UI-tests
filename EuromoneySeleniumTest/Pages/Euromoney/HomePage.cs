using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class HomePage : BasePage
    {
        public HomePage()
		{
            baseUrl = "http://www.euromoneyplc.com/";
            pageTitle = "Home | Euromoney Institutional Investor PLC";
        }

        public Header Header
        {
            get { return new Header(); }
        }

        public SideMenu SideMenu
        {
            get { return new SideMenu(); }
        }
    }
}
