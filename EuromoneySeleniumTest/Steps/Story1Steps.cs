using EuromoneySeleniumTest.Pages;
using System;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Steps
{
    [Binding]
    public class Story1Steps : BaseSteps
    {
        HomePage homePage;

        [Given(@"I opened the home page")]
        public void GivenIOpenedTheHomePage()
        {
            homePage = new HomePage();
            homePage.Open();
        }
        
        [Given(@"I open side menu")]
        public void GivenIOpenSideMenu()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click ""(.*)"" first level menu link")]
        public void WhenIClickFirstLevelMenuLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Submenu will be opened")]
        public void ThenSubmenuWillBeOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"then I click ""(.*)"" second level menu link")]
        public void ThenThenIClickSecondLevelMenuLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"""(.*)"" page should be opened")]
        public void ThenPageShouldBeOpened(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Page is dispayed correctly")]
        public void ThenPageIsDispayedCorrectly()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"images have an url")]
        public void ThenImagesHaveAnUrl()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
