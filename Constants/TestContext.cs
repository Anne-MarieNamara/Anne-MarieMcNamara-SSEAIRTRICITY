using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SSE_1.Constants.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SSE_1.Constants
{
    public static class TestContext
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;
        //public static BrowserName browser = BrowserName.EdgeBrowser;
        public static BrowserName browser = BrowserName.FirefoxBrowser;
    }
}
