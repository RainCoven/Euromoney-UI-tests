using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    public partial class EuromoneySteps : BaseSteps
    {
        [When(@"I will open side menu")]
        public void WhenIWillOpenSideMenu()
        {
            _sideMenu = _managmentPage.SideMenu;
            _sideMenu.ShowMenuButton.Click();
        }

        [Then(@"menu will be visible")]
        public void ThenMenuWillBeVisible()
        {
            Assert.True(_sideMenu.Menu.Displayed, "Error: menu aren't visible");
        }

        [Then(@"menu will have next links")]
        public void ThenMenuWillHaveNextLinks(Table table)
        {
            foreach(TableRow row in table.Rows)
            {
                var link = _sideMenu.GetMenuLink(row["Link"]);
                Assert.True(link.Displayed, "Error: there is no link with name" + row["Link"] + "in menu");
            }
        }

        [Then(@"footer will be visible")]
        public void ThenFooterWillBeVisivle()
        {
            Assert.True(_sideMenu.Footer.Displayed);
        }

        [Then(@"LinkedIn icon will be presrsent")]
        public void ThenLinkedInIconWillBePresrsent()
        {
            Assert.True(_sideMenu.LinkedInButton.Displayed, "Error: trere is no no LinkedIn reference in the footer.");
        }

        [Then(@"footer menu will have next links")]
        public void ThenFooterMenuWillHaveNextLinks(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                var link = _sideMenu.GetFooterLink(row["Link"]);
                Assert.True(link.Displayed, "Error: there is no link with name" + row["Link"] + "in menu");
            }
        }

    }
}
