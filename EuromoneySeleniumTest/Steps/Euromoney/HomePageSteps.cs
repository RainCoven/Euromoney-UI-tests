using EuromoneySeleniumTest.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using EuromoneySeleniumTest.Pages.Euromoney;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    [Binding]
    public class HomePageSteps : BaseSteps
    {
        HomePage _homePage;
        Header _header;
        SideMenu _sideMenu;
        IWebElement _subMenu;

        public HomePageSteps()
        {
            _homePage = new HomePage();
            _header = new Header();
        }

        [Given(@"I opened the home page")]
        public void GivenIOpenedTheHomePage()
        {
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
        
        [Then(@"""(.*)"" page should be opened")]
        public void ThenPageShouldBeOpened(string pageTitle)
        {
            ManagmentPage page = new ManagmentPage();
            page.verifyPage(pageTitle);
        }
    }
}
