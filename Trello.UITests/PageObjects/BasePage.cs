using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Trello.Helpers.Configuration;

namespace Trello.PageObjects
{
    public class BasePage
    {
        public static IWebDriver Driver;
        public static WebDriverWait waitDriver;
        public string PageUrl = ConfigurationProvider.TestsConfiguration["BaseUrl"];

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            waitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public void LoadPage()
        {
            Driver.Url = PageUrl;
            waitDriver.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
