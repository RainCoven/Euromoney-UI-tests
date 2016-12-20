using BasePageObjectModel;
using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages
{
    class HomePage : BasePage
    {
        public HomePage()
		{
            baseUrl = "http://www.euromoneyplc.com/";
        }
    }
}
