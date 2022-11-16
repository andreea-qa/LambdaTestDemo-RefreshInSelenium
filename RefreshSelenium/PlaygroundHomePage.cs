using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshSelenium
{
    internal class PlaygroundHomePage
    {
        private IWebDriver driver;
        public PlaygroundHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SimpleFormLink => driver.FindElement(By.LinkText("Simple Form Demo"));
        public IWebElement RadioButtonsLink => driver.FindElement(By.LinkText("Radio Buttons Demo"));

      
        internal void GoToSimpleFormDemoPage()
        {
            SimpleFormLink.Click();
        }
        internal void GoToRadioButtonsDemoPage()
        {
            RadioButtonsLink.Click();
        }

        internal void NavigateToLink(IWebElement pageLink)
        {
            pageLink.Click();
        }

    }
}
