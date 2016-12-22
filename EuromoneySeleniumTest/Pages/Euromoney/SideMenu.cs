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

        public IWebElement ShowMenuButton
        {
            get { return driver.FindElement(By.ClassName("icon-nav"));  }
        }

        public IWebElement Footer
        {
            get { return driver.FindElement(By.Id("site_footer")); }
        }


        public IWebElement LinkedInButton
        {
            get { return Footer.FindElement(By.ClassName("icon-linkedin")); }
        }

        public IWebElement Menu
        {
            get { return driver.FindElement(By.Id("menu")); }
        }

        public IWebElement ClickFirstLevelMenuItem(string itemName)
        {
            var item = Menu.FindElement(By.XPath("//ul[@id='menu']/li/a[contains(text(), '" + itemName + "')]"));

            Assert.IsTrue(item.Displayed, "Error: no link with name " + itemName);

            item.Click();

            var secondLevelMenu = item.GetParent().FindElement(By.TagName("ul"));

            Assert.IsTrue(secondLevelMenu.Displayed, "Error: item has no 2nd level menu");

            return secondLevelMenu;
        }

        public void ClickSecondLevelMenuItem(IWebElement menu,  string itemName)
        {
            var item = menu.FindElement(By.XPath("//ul[@id='menu']/li/ul/li/a[contains(text(), '" + itemName + "')]"));
            Assert.IsTrue(item.Displayed, "Error: no link with name " + itemName);
            Assert.AreEqual(itemName, item.Text);
            item.Click();
        }

        public IWebElement GetMenuLink(string linkText)
        {
            return Menu.FindElement(By.XPath("//ul[@id='menu']/li/a[contains(text(), '" + linkText + "')]"));
        }

        public IWebElement GetFooterLink(string linkText)
        {
            return Footer.FindElement(By.LinkText(linkText));
        }
    }
}
