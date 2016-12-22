using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace EuromoneySeleniumTest.Steps
{
    [Binding]
    public class BaseSteps
    {
        readonly IWebDriver driver;


        public BaseSteps()
        {
        }
    }
}
