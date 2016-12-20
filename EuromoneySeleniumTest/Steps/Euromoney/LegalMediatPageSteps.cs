using EuromoneySeleniumTest.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using EuromoneySeleniumTest.Pages.Euromoney;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    [Binding]
    public class LegalMediatPageSteps : BaseSteps
    {
        LegalMediaPage _legalMediaPage;
        Header _header;
        BasePage _page;
        PortfolioPage _portfolioPage;

        public LegalMediatPageSteps()
        {
            _legalMediaPage = new LegalMediaPage();
            _header = new Header();
            _portfolioPage = new PortfolioPage();
            _page = new BasePage();
        }

        [When(@"I click Portholio button")]
        public void WhenIClickPortholioButton()
        {
            _header.portfolioLink.Click();
        }

        [Then(@"page title is ""(.*)""")]
        [Then(@"""(.*)"" page should be opened")]
        public void ThenPageShouldOpen(string pageTitle)
        {
            _page.verifyPage(pageTitle);
        }

        [Given(@"I am on the Our portfolio page")]
        public void GivenIAmOnTheOurPortfolioPage()
        {
            _portfolioPage.Open();
        }

        [When(@"I click on Legal media link")]
        public void WhenIClickOnLegalMediaLink()
        {
            _portfolioPage.legalMediaLink.Click();
        }

        [Then(@"page has ""(.*)"" link")]
        public void ThenPageHasLink(string linkText)
        {
            IWebDriver driver = (IWebDriver)ScenarioContext.Current["driver"];
            var link = driver.FindElement(By.LinkText(linkText));
            Assert.True(link.Displayed);
        }
    }
}

