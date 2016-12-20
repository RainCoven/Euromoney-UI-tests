﻿using OpenQA.Selenium;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    class Header : BasePage
    {
        public Header()
		{
            
        }

        public IWebElement menuButton {
            get { return driver.FindElement(By.CssSelector(".main_navigation .menu_trigger")); }
        }

        public IWebElement portfolioLink
        {
            get { return driver.FindElement(By.XPath("//header//a[@href='/our-portfolio']")); }
        }
    }
}
