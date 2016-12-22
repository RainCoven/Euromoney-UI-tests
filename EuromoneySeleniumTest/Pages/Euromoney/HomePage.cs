using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class HomePage : BasePage
    {
        public HomePage()
		{
            url = euromoneyUrl;
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
