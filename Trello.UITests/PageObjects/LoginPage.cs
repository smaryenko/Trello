using OpenQA.Selenium;

using static OpenQA.Selenium.Support.UI.ExpectedConditions;

namespace Trello.PageObjects
{
    public class LoginPage : BasePage
    {
        public By InputEmail => By.Id("user");
        public By InputPassword => By.Id("password");
        public By ButtonLogin => By.Id("login");
        public By MessageContainer => By.Id("error");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            PageUrl += "/login";
        }

        public void Login(string email, string password)
        {
            waitDriver.Until(ElementIsVisible(InputEmail));
            Driver.FindElement(InputEmail).SendKeys(email);

            waitDriver.Until(ElementIsVisible(InputPassword));
            Driver.FindElement(InputPassword).SendKeys(password);

            waitDriver.Until(ElementToBeClickable(ButtonLogin)).Click();
        }

        public void WaitForError(string error)
        {
            var element = Driver.FindElement(MessageContainer);
            waitDriver.Until(TextToBePresentInElement(element, error));
        }
    }
}
