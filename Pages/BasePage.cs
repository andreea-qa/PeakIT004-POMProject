using OpenQA.Selenium;

namespace POMProject.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        private string title;
        private IWebElement LoggedUser => driver.FindElement(By.Id("welcome"));

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.title = title;
        }

        private IWebElement AdminMenuLink => driver.FindElement(By.Id("menu_admin_viewAdminModule"));

        public UserManagementPage OpenUserManagementPage()
        {
            AdminMenuLink.Click();
            return new UserManagementPage(driver);
        }

        public bool IsUserLoggedIn(string username)
        {
            return LoggedUser.Text.Contains(username);
        }

        public virtual bool IsTitleCorrect()
        {
            return driver.Title.Equals(title);
        }
    }
}
