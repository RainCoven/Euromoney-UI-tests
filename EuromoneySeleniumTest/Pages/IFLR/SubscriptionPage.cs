﻿using BasePageObjectModel;
using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.IFLR
{
    class SubscriptionPage : BasePage
    {
        public SubscriptionPage()
		{
            baseUrl = "http://www.iflr.com/Subscription-Groups.html";
            pageTitle = "IFLR - International Financial Law Review";
        }

        public IWebElement PersonalSubscriptionButton
        {
            get { return driver.FindElement(By.XPath("//*[@id='content']/div/table/tbody/tr[4]/td[1]/a")); }
        }

        public IWebElement Packages
        {
            get { return driver.FindElement(By.ClassName("packages")); }
        }
    }
}
