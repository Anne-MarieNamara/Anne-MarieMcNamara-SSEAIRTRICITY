using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SSE_1.Helpers;
using SSE_1.ObjectRepository;
using System.Threading;
using TechTalk.SpecFlow;
using static SSE_1.Constants.TestContext;
using static SSE_1.ApplicationContext.ApplicationContext;
using OpenQA.Selenium.Firefox;

namespace SSE_1.StepDefinitions
{
    [Binding]
    public class SharedStepDefinitions
    {

        [Given(@"user opens url")]
        public void GivenUserOpensUrl()
        {
            string Url = "https://www.citizensadvice.org.uk/consumer/energy/energy-supply/get-help-paying-your-bills/check-how-much-your-electrical-appliances-cost-to-use/";
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }       


        [Given(@"user clicks on '(.*)' button")]
        public void GivenUserClicksOnButton(string button)
        {
            switch (button)
            {
                case "location":
                    IWebElement locationButtonXpath = driver.FindElement(By.XPath(PageObjects.locationButtonXpath));
                    locationButtonXpath.Click();
                    Thread.Sleep(1250);
                    break;

                case "england":
                    IWebElement englandButtonXpath = driver.FindElement(By.XPath(PageObjects.locationEnglandXpathButton));
                    englandButtonXpath.Click();
                    ApplicationContext.ApplicationContext.LocationName = "England";
                    Thread.Sleep(1250);
                    break;

                case "scotland":
                    IWebElement scotlandButtonXpath = driver.FindElement(By.XPath(PageObjects.locationScotlandXpathButton));
                    scotlandButtonXpath.Click();
                    ApplicationContext.ApplicationContext.LocationName = "Scotland";
                    Thread.Sleep(1250);
                    break;

                case "wales":
                    IWebElement walesButtonXpath = driver.FindElement(By.XPath(PageObjects.locationWalesXpathButton));
                    walesButtonXpath.Click();
                    ApplicationContext.ApplicationContext.LocationName = "Wales";
                    Thread.Sleep(1250);
                    break;

                case "northern ireland":
                    IWebElement niButtonXpath = driver.FindElement(By.XPath(PageObjects.locationNIXpathButton));
                    niButtonXpath.Click();
                    ApplicationContext.ApplicationContext.LocationName = "Northern Ireland";
                    Thread.Sleep(1250);
                    break;

                case "add appliance to your list":
                    //ScrollToAddApplianceButton();
                    Thread.Sleep(2000);
                    IWebElement addApplianceButtonXpath = driver.FindElement(By.Id(PageObjects.addApplicanceToListButtonId));
                    addApplianceButtonXpath.Click();
                    Thread.Sleep(1250);
                    break;

                default:
                    Assert.Fail("Invalid button");
                    break;
            }
        }
        public static void ScrollToAddApplianceButton()
        {          
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath(PageObjects.addApplianceToListXpath)));
                Thread.Sleep(1250);          
        }

        [Given(@"user Validates that modal has popped up")]
        public void GivenUserValidatesThatModalHasPoppedUp()
        {
            bool isLocationModalDisplayed = driver.FindElements(By.XPath(PageObjects.locationModalTitleXpath)).Count > 0;
            if (isLocationModalDisplayed)
            {
                Console.WriteLine("Correct modal is displayed");
            }
            Thread.Sleep(1250);
        }

        [Given(@"user scrolls down to Calculator")]
        public void GivenUserScrollsDownToCalculator()
        {
            bool isCalculatorDisplayed = driver.FindElements(By.Id(PageObjects.addApplicanceToListButtonId)).Count > 0;
            if (!isCalculatorDisplayed)
            {
                //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.Id(PageObjects.useTheCalculatorId)));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.Id(PageObjects.appliancesListId)));
                
                Thread.Sleep(1250);
            }                        

            bool isCookieMessageDisplayed = driver.FindElements(By.XPath(PageObjects.cookieMessageXpath)).Count > 0;
            if (isCookieMessageDisplayed)
            {
                IWebElement closeCookieButtonXpath = driver.FindElement(By.XPath(PageObjects.cookieMessageXpath));
                closeCookieButtonXpath.Click();
                Thread.Sleep(2000);
            }
        }

        [Given(@"user clicks on Add an appliance and chooses '(.*)'")]
        public void GivenUserClicksOnAddAnApplianceAndChooses(string appliance)
        {
            SelectElement addAnApplianceID = new SelectElement(driver.FindElement(By.Id(PageObjects.appliancesListId)));

            switch (appliance)
            {
                case "electric blanket":
                    addAnApplianceID.SelectByText("Electric blanket");
                    break;

                case "immersion heater":
                    addAnApplianceID.SelectByText("Immersion heater");
                    break;

                case "fan heater":
                    addAnApplianceID.SelectByText("Fan heater");
                    break;

                case "panel heater or electric fire (not central heating)":
                    addAnApplianceID.SelectByText("Panel heater or electric fire (not central heating)");
                    break;

                case "broadband router":
                    addAnApplianceID.SelectByText("Broadband router");
                    break;

                case "pc or desktop computer":
                    addAnApplianceID.SelectByText("PC or desktop computer");
                    break;

                case "tv":
                    addAnApplianceID.SelectByText("TV");
                    break;

                case "phone or tablet charger":
                    addAnApplianceID.SelectByText("Phone or tablet charger");
                    break;

                case "grill or hob(electric)":
                    addAnApplianceID.SelectByText("Grill or hob (electric)");
                    break;

                case "light bulb - energy saving led":
                    addAnApplianceID.SelectByText("Light bulb - energy-saving LED");
                    break;

                case "kettle":
                    addAnApplianceID.SelectByText("Kettle");
                    break;

                case "heat pump (air source)":
                    addAnApplianceID.SelectByText("Heat pump (air source)");
                    break;

                case "light bulb - energy saving cfl":
                    addAnApplianceID.SelectByText("Light bulb - energy-saving CFL");
                    break;

                default:
                    Assert.Fail("Invalid appliance");
                    break;
            }
            Thread.Sleep(1250);
        }


        [Given(@"user chooses '(.*)' hours and '(.*)' minutes")]
        public void GivenUserChoosesHoursAndMinutes(int hours, int minutes)
        {
            IWebElement hoursId = driver.FindElement(By.Id(PageObjects.hoursId));
            hoursId.Click();
            hoursId.Clear();
            hoursId.SendKeys(hours.ToString());
            Thread.Sleep(1250);
            hoursId.SendKeys(Keys.Tab);

            IWebElement minutesId = driver.FindElement(By.Id(PageObjects.minutesId));
            minutesId.Click();
            minutesId.Clear();
            minutesId.SendKeys(minutes.ToString());
            Thread.Sleep(1250);

        }

        [Given(@"user chooses every day")]
        public void GivenUserChoosesEveryDay()
        {
            SelectElement frequencyOptionDropDown = new SelectElement(driver.FindElement(By.Id(PageObjects.frequencyOptionDropDown)));
            frequencyOptionDropDown.SelectByValue("day");
            Thread.Sleep(1250);
        }
   

        [Given(@"user clicks on p/kwh and inputs '(.*)'")]
        public void GivenUserClicksOnPKwhAndInputs(int rate)
        {
            IWebElement pkWhRateId = driver.FindElement(By.Id(PageObjects.perKilowattHourId));
            pkWhRateId.Click();
            pkWhRateId.Clear();
            pkWhRateId.SendKeys(rate.ToString());
            Thread.Sleep(1250);
            pkWhRateId.SendKeys(Keys.Tab);
            Thread.Sleep(1250);
            //ChangeFocus();
        }

        public static void ChangeFocus()
        {
            // Click on Calculator Title
            IWebElement calcTitleId = driver.FindElement(By.Id(PageObjects.useTheCalculatorId));
            calcTitleId.Click();
            Thread.Sleep(2000);
        }

        [Given(@"user scrolls to Appliance Table")]
        public void GivenUserScrollsToApplianceTable()
        {
            ChangeFocus();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath(PageObjects.ApplianceTableTitleXpath)));
            Thread.Sleep(1250);
        }

        [Given(@"user validates the most expensive appliance")]
        public void GivenUserValidatesTheMostExpensiveAppliance()
        {
            bool isMostExpensiveDisplayedId = driver.FindElements(By.Id(PageObjects.mostExpensiveTitleId)).Count >0;
            if (isMostExpensiveDisplayedId)
            {
                Console.WriteLine("Scroll successfull");
            }

            //Get most expensive item
            string mostExpensiveAppliance = null; 
            
            string locationNameStr = ApplicationContext.ApplicationContext.LocationName;

            if (locationNameStr == "England")
            {
                mostExpensiveAppliance = "Fan heater";
            }
            else if (locationNameStr == "Scotland")
            {
                mostExpensiveAppliance = "Panel heater or electric fire (not central heating)";
            }
            else if (locationNameStr == "Wales")
            {
                mostExpensiveAppliance = "Kettle";
            }
            IWebElement mostExpensiveTextXpath = driver.FindElement(By.Id(PageObjects.mostExpensiveAppId));
            string expectedMostExpensive = mostExpensiveAppliance;
            string actualMostExpensive = mostExpensiveTextXpath.Text.Trim();
            MiscHelperClass.ValidateMethod(expectedMostExpensive, actualMostExpensive);            
        }


        [Then(@"user validates the other appliances in the table")]
        public void ThenUserValidatesTheOtherAppliancesInTheTable()
        {
            string locationNameStr = ApplicationContext.ApplicationContext.LocationName;
            string expectedTotalAppliances = null;
            string expectedTotalDailyAmts = null;
            string expectedTotalWeeklyAmts = null;
            string expectedTotalMonthlyAmts = null;
            string expectedTotalYearlyAmts = null;

            // Count total appliances in table
            List<IWebElement> tableOfAppliancesListXpath = driver.FindElements(By.XPath(PageObjects.applicanceHeaderForItemXpath)).ToList();
            string actualTotalAppliancesStr = tableOfAppliancesListXpath.Count().ToString();

            if (locationNameStr == "England")
            {
                expectedTotalAppliances = "8";
                expectedTotalDailyAmts = "8";
                expectedTotalWeeklyAmts = "8";
                expectedTotalMonthlyAmts = "8";
                expectedTotalYearlyAmts = "8";
            }
            else if (locationNameStr == "Scotland")
            {
                expectedTotalAppliances = "10";
                expectedTotalDailyAmts = "10";
                expectedTotalWeeklyAmts = "10";
                expectedTotalMonthlyAmts = "10";
                expectedTotalYearlyAmts = "10";
            }
            else if (locationNameStr == "Wales")
            {
                expectedTotalAppliances = "5";
                expectedTotalDailyAmts = "5";
                expectedTotalWeeklyAmts = "5";
                expectedTotalMonthlyAmts = "5";
                expectedTotalYearlyAmts = "5";
            }

            // Check that appliance totals match
            MiscHelperClass.ValidateMethod(actualTotalAppliancesStr, expectedTotalAppliances);

            // Check the Daily, Weekly, Monthly and Yearly in the table                          

            // Count Daily in table            
            List<IWebElement> AllDailyAmountsListXpath = driver.FindElements(By.XPath(PageObjects.dailyXpath)).ToList();
            string actualTotalDailyAmts = AllDailyAmountsListXpath.Count().ToString();
            MiscHelperClass.ValidateMethod(expectedTotalDailyAmts, actualTotalDailyAmts);

            // Count Weekly in table           
            List<IWebElement> AllWeeklyAmountsListXpath = driver.FindElements(By.XPath(PageObjects.weeklyXpath)).ToList();
            string actualTotalWeeklyAmts = AllWeeklyAmountsListXpath.Count().ToString();
            MiscHelperClass.ValidateMethod(expectedTotalWeeklyAmts, actualTotalWeeklyAmts);

            // Count Monthly in table           
            List<IWebElement> AllMonthlyAmountsListXpath = driver.FindElements(By.XPath(PageObjects.monthlyXpath)).ToList();
            string actualTotalMonthlyAmts = AllMonthlyAmountsListXpath.Count().ToString();
            MiscHelperClass.ValidateMethod(expectedTotalMonthlyAmts, actualTotalMonthlyAmts);

            // Count Yearly in table           
            List<IWebElement> AllYearlyAmountsListXpath = driver.FindElements(By.XPath(PageObjects.yearlyXpath)).ToList();
            string actualTotalYearlyAmts = AllYearlyAmountsListXpath.Count().ToString();
            MiscHelperClass.ValidateMethod(expectedTotalYearlyAmts, actualTotalYearlyAmts);

        }

        [Then(@"user validates the other appliances in the table for ""(.*)""")]
        public void ThenUserValidatesTheOtherAppliancesInTheTableFor(string country)
        {
            switch (country)
            {
                case "england":
                    break;

                case "scotland":
                    break;

                case "wales":

                    break;

                case "default":
                    Assert.Fail("Invalid country");
                    break;
            }
        }


        [Then(@"user validates text")]
        public void ThenUserValidatesText()
        {         
            bool isNITitleTextDisplayed = driver.FindElements(By.XPath(PageObjects.niTitleXpath)).Count > 0;
            if (isNITitleTextDisplayed)
            {
                Console.WriteLine("Correct page is displayed");
            }

            IWebElement niTextXpath = driver.FindElement(By.XPath(PageObjects.niAdviceTextXpath));
            string actualNIText = niTextXpath.Text.Trim();
            string expectedNIText = PageObjects.niAdviceTextStr;
            MiscHelperClass.ValidateMethod(actualNIText, expectedNIText);
        }

    }
}
