using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    public partial class EuromoneySteps : BaseSteps
    {
        [When(@"I will open side menu")]
        public void WhenIWillOpenSideMenu()
        {
            _sideMenu = new Pages.Euromoney.SideMenu();
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
                var link = _sideMenu.menu.FindElement(By.XPath("//ul[@id='menu']/li/a[contains(text(), '" + row["Link"] + "')]"));
                Assert.True(link.Displayed, "Error: there is no link with name" + row["Link"] + "in menu");
            }
        }

        [Then(@"footer will be visible")]
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
                var link = _sideMenu.footer.FindElement(By.LinkText(row["Link"]));
                Assert.True(link.Displayed, "Error: there is no link with name" + row["Link"] + "in menu");
            }
        }

    }
}
