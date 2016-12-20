using EuromoneySeleniumTest.Pages.Euromoney;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    public partial class EuromoneySteps : BaseSteps
    {
        [Given(@"I opened the home page")]
        public void GivenIOpenedTheHomePage()
        {
            _homePage = new HomePage();
            _homePage.Open();
        }
        
        [Given(@"I open side menu")]
        public void GivenIOpenSideMenu()
        {
            _header.menuButton.Click();
            Assert.True(_header.menuButton.Displayed, "Menu aren't visible");
        }
        
        [When(@"I click ""(.*)"" first level menu link")]
        public void WhenIClickFirstLevelMenuLink(string linkName)
        {
            _sideMenu = new SideMenu();
            _subMenu = _sideMenu.clickFirstLevelMenuItem(linkName);
        }
        
        [Then(@"Submenu will be opened")]
        public void ThenSubmenuWillBeOpened()
        {
            Assert.True(_subMenu.Displayed);
        }
        
        [Then(@"then I click ""(.*)"" second level menu link")]
        public void ThenThenIClickSecondLevelMenuLink(string linkName)
        {
            _sideMenu.clickSecondLevelMenuItem(_subMenu, linkName);
        }
    }
}
