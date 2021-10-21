using OpenQA.Selenium;

namespace POMProject.Pages
{
    class AdminPage : BasePage
    {
        public AdminPage(IWebDriver driver) : base(driver) { }
        private IWebElement LoggedUser => driver.FindElement(By.Id("welcome"));

        public override bool IsTitleCorrect()
        {
            return driver.Title.Equals("OrangeHRM");
        }

        public override bool IsUserLoggedIn(string username)
        {
            return LoggedUser.Text.Contains(username);
        }
}
}
