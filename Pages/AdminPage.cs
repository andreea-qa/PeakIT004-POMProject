using OpenQA.Selenium;

namespace POMProject.Pages
{
    class AdminPage : BasePage
    {
        public AdminPage(IWebDriver driver) : base(driver) {  }

        private IWebElement LoggedUser => driver.FindElement(By.Id("welcome"));

        public bool IsUserLoggedIn(string username)
        {
            return LoggedUser.Text.Contains(username);
        }

        // Method in derived page
        public override bool IsTitleCorrect()
        {
            return driver.Title.Equals("OrangeHRM");
        }
    }
}
