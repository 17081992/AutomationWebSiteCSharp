using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationWebSiteCsharp
{
    class Contact
    {
        private IWebDriver driver;

        public Contact(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Contact')]")]
        private IWebElement contact;
        public IWebElement ContactUs() { return contact; }

    }
}
