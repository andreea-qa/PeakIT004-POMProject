using OpenQA.Selenium;

namespace POMProject.Pages
{
    public class BasePage
    {
        private readonly IWebDriver driver;

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
    }
}
