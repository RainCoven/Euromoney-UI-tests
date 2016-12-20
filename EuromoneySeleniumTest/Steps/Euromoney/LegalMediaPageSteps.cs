using EuromoneySeleniumTest.Pages.Euromoney;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Steps.Euromoney
{
    public partial class EuromoneySteps : BaseSteps
    {
        [When(@"I click Portholio button")]
        public void WhenIClickPortholioButton()
        {
            _header = new Header();
            _header.portfolioLink.Click();
        }

        [Given(@"I am on the Our portfolio page")]
        public void GivenIAmOnTheOurPortfolioPage()
        {
            _portfolioPage = new PortfolioPage();
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

        [Given(@"I am on the Legal Media page")]
        public void GivenIAmOnTheLegalMediaPage()
        {
            _legalMediaPage = new LegalMediaPage();
            _legalMediaPage.Open();
        }

        [When(@"I click VISIT IFLR link")]
        public void WhenIClickVISITIFLRLink()
        {
            _legalMediaPage.IFLRLink.Click();
        }

        [Then(@"I should see Portfolio page")]
        public void ThenIShouldSeePortfolioPage()
        {
            _portfolioPage = new PortfolioPage();
            _portfolioPage.verifyPage();
        }

        [Then(@"I should see Legal media page")]
        public void ThenIShouldSeeLegalMediaPage()
        {
            _legalMediaPage = new LegalMediaPage();
            _legalMediaPage.verifyPage();
        }


    }
}

