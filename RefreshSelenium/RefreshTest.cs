using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

namespace RefreshSelenium
{
    public class RefreshTest
    {

        private static IWebDriver driver;
        private static readonly string gridURL = "@hub.lambdatest.com/wd/hub";
        private static readonly string LT_USERNAME = Environment.GetEnvironmentVariable("LT_USERNAME");
        private static readonly string LT_ACCESS_KEY = Environment.GetEnvironmentVariable("LT_ACCESS_KEY");

        [SetUp]
        public void Setup()
        {
            SafariOptions capabilities = new SafariOptions();
            capabilities.BrowserVersion = "15.0";
            Dictionary<string, object> ltOptions = new Dictionary<string, object>();
            ltOptions.Add("username", LT_USERNAME);
            ltOptions.Add("accessKey", LT_ACCESS_KEY);
            ltOptions.Add("visual", true);
            ltOptions.Add("platformName", "MacOS Monterey");
            ltOptions.Add("build", "Refresh");
            ltOptions.Add("project", "RefrestTest");
            ltOptions.Add("w3c", true);
            ltOptions.Add("plugin", "c#-nunit");
            capabilities.AddAdditionalOption("LT:Options", ltOptions);
            driver = new RemoteWebDriver(new Uri($"https://{LT_USERNAME}:{LT_ACCESS_KEY}{gridURL}"), capabilities);
        }

        [Test]
        public void RefreshPage()
        {
            PlaygroundHomePage homePage = new PlaygroundHomePage(driver);
            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/");
            homePage.NavigateToLink(homePage.SimpleFormLink);
            driver.Navigate().Back();
            
            // Refresh using Navigate Refresh
            driver.Navigate().Refresh();

            // Refresh by pressing the F5 key
            homePage.RadioButtonsLink.SendKeys(Keys.F5);
            
            // Refresh by using the current page Url
            driver.Navigate().GoToUrl(driver.Url);
            homePage.NavigateToLink(homePage.RadioButtonsLink);  
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}