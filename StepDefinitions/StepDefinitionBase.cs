using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using static SSE_1.Constants.Constants;
using static SSE_1.Constants.TestContext;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace SSE_1.StepDefinitions
{
    [Binding]
    public class StepDefinitionBase
    {
        private static TestContext _testContext;

        public StepDefinitionBase(TestContext testContext)
        {
            _testContext = testContext;
        }


        [BeforeScenario]
        public static void DeleteAllCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }


        [BeforeTestRun]
        private static void BeforeTestRun()
        {
            InitBrowser(browser);

        }


        private static void InitBrowser(BrowserName BrowserName)
        {
            switch (BrowserName)
            {
              
                case BrowserName.FirefoxBrowser:
                    //driver = new FirefoxDriver();
                    driver = new FirefoxDriver(@"C:\Users\Anne-Marie\Source\Repos\SSE_1\geckodriver.exe");
                    break;
                //case BrowserName.EdgeBrowser:
                //    driver = new EdgeDriver();
                //    break;
            }
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(15));
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
            driver = null;
        }


    }
}
