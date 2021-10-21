using OpenQA.Selenium;

namespace POMProject.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement DashboardMenuLink => driver.FindElement(By.Id("menu_dashboard_index"));

        public DashboardPage OpenDashboard()
        {
            DashboardMenuLink.Click();
            return new DashboardPage(driver);
        }

        public abstract bool IsTitleCorrect();
    }
}
