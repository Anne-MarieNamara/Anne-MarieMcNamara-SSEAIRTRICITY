using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_1.ObjectRepository
{
    public class PageObjects
    {
        public static string adviceWebsiteUrl = "https://www.citizensadvice.org.uk/consumer/energy/energy-supply/get-help-paying-your-bills/check-how-much-your-electrical-appliances-cost-to-use/";
        public static string locationButtonXpath = "//span[@class='hide-old-designs']/a";
        public static string locationModalTitleXpath = "//h2[text()='Where in the UK do you live?']";
        public static string countryButtonXpath = "//span[contains(text(),'This advice applies to')]/a";
        public static string locationEnglandXpathButton = "//a[text()='England']";
        public static string locationScotlandXpathButton = "//a[text()='Scotland']";
        public static string locationWalesXpathButton = "//a[text()='Wales']";
        public static string locationNIXpathButton = "//a[text()='Northern Ireland']";
        public static string useTheCalculatorId = "h-use-the-calculator";
        public static string appliancesListId = "appliance";
        public static string hoursId = "hours";
        public static string minutesId = "mins";
        public static string perKilowattHourId = "kwhcost";
        public static string frequencyOptionDropDown = "frequency";
        public static string addApplicanceToListButtonId = "submit";
        public static string addApplianceToListXpath = "//input[@value='Add appliance to your list']";
        public static string ApplianceTableTitleXpath = "//th[text()='Appliance']";
        public static string mostExpensiveTitleId = "h-most-expensive-appliance";
        public static string mostExpensiveAppId = "mostHungryName";
        public static string locationNamelinkXpath = "//span[contains(text(),'This advice applies to')]/a";
        public static string applicanceHeaderForItemXpath = "//tbody/tr/td[@headers='appliance-name']";
        public static string niAdviceTextStr = "The advice on this website doesn’t cover Northern Ireland, but you can get help from a trained adviser online, over the phone or face to face.";
        public static string niTitleXpath = "//h1[@class='cads-page-title']";
        public static string niAdviceTextXpath = "(//div[@class='cads-prose']/p)[1]";
        public static string cookieMessageXpath = "//button[@class='button--blue cookie-monster__close']";
        public static string dailyXpath = "//td[text()='Daily']";
        public static string weeklyXpath = "//td[text()='Weekly']";
        public static string monthlyXpath = "//td[text()='Monthly']";
        public static string yearlyXpath = "//td[text()='Yearly']";
        //public static string thing = "";
        //public static string thing = "";
        //public static string thing = "";
    }
}
