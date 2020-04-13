using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Trello.Framework.Helpers.Screenshot;

namespace Trello.StepDefinitions
{
    [Binding]
    public class TestBase
    {
        public static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
           
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
            driver.Quit();
        }

        [AfterScenario]
        public void AfterWebTest()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                ScreenshotHelper.TakeScreenshot(driver);
            }
        }
    }
}
