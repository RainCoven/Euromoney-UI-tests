﻿using EuromoneySeleniumTest.Pages.Euromoney;
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
            _header = _homePage.Header;
            _header.MenuButton.Click();
            Assert.True(_header.MenuButton.Displayed, "Error: Menu aren't visible");
        }
        
        [When(@"I click ""(.*)"" first level menu link")]
        public void WhenIClickFirstLevelMenuLink(string linkName)
        {
            _sideMenu = _homePage.SideMenu;
            _subMenu = _sideMenu.ClickFirstLevelMenuItem(linkName);
        }
        
        [Then(@"Submenu will be opened")]
        public void ThenSubmenuWillBeOpened()
        {
            Assert.True(_subMenu.Displayed, "Error: side menu wasn't opened.");
        }
        
        [Then(@"then I click ""(.*)"" second level menu link")]
        public void ThenThenIClickSecondLevelMenuLink(string linkName)
        {
            _sideMenu.ClickSecondLevelMenuItem(_subMenu, linkName);
        }
    }
}
