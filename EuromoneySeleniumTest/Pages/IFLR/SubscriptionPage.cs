using BasePageObjectModel;
using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.IFLR
{
    class SubscriptionPage : BasePage
    {
        public SubscriptionPage()
		{
            url = iflrUrl + "Subscription-Groups.html";
            pageTitle = "IFLR - International Financial Law Review";
        }

        public IWebElement PersonalSubscriptionButton
        {
            get { return driver.FindElement(By.XPath("//*[@id='content']//a[contains(text(), 'Select')][1]")); }
        }

        public IWebElement Packages
        {
            get { return driver.FindElement(By.ClassName("packages")); }
        }

        public IWebElement GetPackageByName(string name)
        {
            return Packages.FindElement(By.XPath("//h2[contains(text(), '" + name + "')]"));
        }
    }
}
