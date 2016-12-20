using BasePageObjectModel;
using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.IFLR
{
    class CheckoutPage : BasePage
    {
        public CheckoutPage()
		{
            baseUrl = "http://www.iflr.com/Checkoutl";
            pageTitle = "Euromoney Checkout";
        }
    }
}
