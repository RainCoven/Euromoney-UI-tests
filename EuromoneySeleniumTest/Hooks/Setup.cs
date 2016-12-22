using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace EuromoneySeleniumTest.Hooks
{
    [Binding]
    public sealed class Setup
    {
        static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeWebScenario()
        {
            driver = new ChromeDriver();
            ScenarioContext.Current["driver"] = driver;
        }

        [AfterScenario]
        public static void AfterWebScenario()
        {
            driver.Quit();
        }
    }
       
}