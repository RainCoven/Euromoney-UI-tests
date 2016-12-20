using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace EuromoneySeleniumTest.Pages
{
    [Binding]
    class BasePage
    {
        readonly IWebDriver driver;
        public static string baseUrl;
        public BasePage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void type(string inputText, By locator)
        {
            find(locator).SendKeys(inputText);
        }

        public IWebElement find(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }

        public void verifyPage(string pageTitle)
        {
            if (!pageTitle.Equals(driver.Title))
            {
                throw new InvalidOperationException("This page is not " + pageTitle + ". The title is: " + driver.Title);
            }
        }

        public void visit(string url, string pageTitle)
        {
            driver.Navigate().GoToUrl(baseUrl + url);
            verifyPage(pageTitle);
        }

        public void click(By locator)
        {
            find(locator).Click();
        }

        public string getText(By locator)
        {
            return find(locator).Text;
        }

        public bool isElementPresent(By locator, string expectedText)
        {

            IList<IWebElement> subelements = driver.FindElements(locator);
            for (int i = 0; i < subelements.Count; i++)
            {
                if (subelements[i].Text == expectedText)
                {
                    Console.Write("Element Found " + subelements[i].Text);
                    return true;

                }
            }
            return false;
        }

        public bool isDisplayed(By locator)
        {
            try
            {
                IWebElement element = find(locator);
                return element.Displayed && element.Enabled;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }

        public void submit(By locator)
        {
            find(locator).Submit();
        }

        public string getLinkDestination(By locator)
        {
            return find(locator).GetAttribute("href");
        }

        public void check(By locator)
        {
            IWebElement element = find(locator);
            if (!element.Selected)
            {
                element.Click();
            }
        }

        public void uncheck(By locator)
        {
            IWebElement element = find(locator);
            if (element.Selected)
            {
                element.Click();
            }
        }

        public bool isSelected(By locator)
        {
            return find(locator).Selected;
        }
    }
}