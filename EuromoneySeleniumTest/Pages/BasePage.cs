using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using NUnit.Framework;

namespace EuromoneySeleniumTest.Pages
{
    [Binding]
    public class BasePage
    {
        public IWebDriver driver;
        public static string baseUrl;
        public static string pageTitle;

        public BasePage()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public IWebElement Find(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }

        public void VerifyPage(string pageTitle)
        {
            if (!pageTitle.Equals(driver.Title))
            {
                throw new InvalidOperationException("This page is not " + pageTitle + ". The title is: " + driver.Title);
            }
        }

        public void VerifyPage()
        {
            VerifyPage(pageTitle);
        }

        public void Visit(string url, string pageTitle)
        {
            driver.Navigate().GoToUrl(baseUrl + url);
            VerifyPage(pageTitle);
        }

        public bool IsElementPresent(By locator, string expectedText)
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

        public bool IsDisplayed(By locator)
        {
            try
            {
                IWebElement element = Find(locator);
                return element.Displayed && element.Enabled;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }
    }
}