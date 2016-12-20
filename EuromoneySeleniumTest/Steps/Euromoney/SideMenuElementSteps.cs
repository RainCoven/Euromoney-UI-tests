using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using EuromoneySeleniumTest.Pages.Euromoney;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    [Binding]
    public class SideMenuElementSteps : BaseSteps
    {
        SideMenu _sideMenu;
        Header _header;

        public SideMenuElementSteps()
        {
            _sideMenu = new SideMenu();
        }

        [When(@"I will open side menu")]
        public void WhenIWillOpenSideMenu()
        {
            _sideMenu.openSideMenu();
        }

        [Then(@"menu will be visible")]
        public void ThenMenuWillBeVisible()
        {
            Assert.True(_sideMenu.menu.Displayed, "Error: menu aren't visible");
        }

        [Then(@"menu will have next links")]
        public void ThenMenuWillHaveNextLinks(Table table)
        {
            foreach(TableRow row in table.Rows)
            {
                var link = _sideMenu.menu.FindElement(By.LinkText(row["link"]));
                Assert.True(link.Displayed, "Error: there is no link with name" + row["link"] + "in menu");
            }
        }

        [Then(@"footer will be visivle")]
        public void ThenFooterWillBeVisivle()
        {
            Assert.True(_sideMenu.footer.Displayed);
        }

        [Then(@"LinkedIn icon will be presrsent")]
        public void ThenLinkedInIconWillBePresrsent()
        {
            Assert.True(_sideMenu.LinkedInButton.Displayed);
        }

        [Then(@"footer menu will have next links")]
        public void ThenFooterMenuWillHaveNextLinks(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                var link = _sideMenu.footer.FindElement(By.LinkText(row["link"]));
                Assert.True(link.Displayed, "Error: there is no link with name" + row["link"] + "in menu");
            }
        }

    }
}
