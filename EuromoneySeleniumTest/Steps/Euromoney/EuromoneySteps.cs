using EuromoneySeleniumTest.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using EuromoneySeleniumTest.Pages.Euromoney;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    [Binding]
    public partial class EuromoneySteps : BaseSteps
    {
        HomePage _homePage;
        Header _header;
        SideMenu _sideMenu;
        IWebElement _subMenu;
        LegalMediaPage _legalMediaPage;
        BasePage _page;
        PortfolioPage _portfolioPage;
        ManagmentPage _managmentPage;

        public EuromoneySteps()
        {
            _page = new BasePage();
        }
    }
}
