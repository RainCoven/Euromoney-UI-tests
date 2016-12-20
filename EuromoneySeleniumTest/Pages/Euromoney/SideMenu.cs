using BasePageObjectModel;
using OpenQA.Selenium;
using NUnit.Framework;

namespace EuromoneySeleniumTest.Pages.Euromoney
{
    public class SideMenu : BasePage
    {
        public SideMenu()
        {
        }

        public IWebElement footer
        {
            get { return driver.FindElement(By.Id("site_footer")); }
        }


        public IWebElement LinkedInButton
        {
            get { return footer.FindElement(By.ClassName("icon-linkedin")); }
        }

        public IWebElement menu
        {
            get { return driver.FindElement(By.Id("menu")); }
        }

        public IWebElement clickFirstLevelMenuItem(string itemName)
        {
            var item = menu.FindElement(By.XPath("//ul[@id='menu']/li/a[contains(text(), '" + itemName + "')]"));

            Assert.IsTrue(item.Displayed, "Error: no link with name " + itemName);

            item.Click();

            var secondLevelMenu = item.GetParent().FindElement(By.TagName("ul"));

            Assert.IsTrue(secondLevelMenu.Displayed, "Error: item has no 2nd level menu");

            return secondLevelMenu;
        }

        public void clickSecondLevelMenuItem(IWebElement menu,  string itemName)
        {
            var item = menu.FindElement(By.XPath("//ul[@id='menu']/li/ul/li/a[contains(text(), '" + itemName + "')]"));
            Assert.IsTrue(item.Displayed, "Error: no link with name " + itemName);
            item.Click();
        }

        public void openSideMenu()
        {
            driver.FindElement(By.ClassName("icon-nav")).Click();
        }
    }
}
