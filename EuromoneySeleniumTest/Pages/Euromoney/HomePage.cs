using BasePageObjectModel;
using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class HomePage : BasePage
    {
        public HomePage()
		{
            baseUrl = "http://www.euromoneyplc.com/";
        }
    }
}
