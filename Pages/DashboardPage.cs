using OpenQA.Selenium;

namespace POMProject.Pages
{
    public class DashboardPage : BasePage
    {
        public DashboardPage(IWebDriver driver) : base(driver) { }

        public override bool IsTitleCorrect()
        {
            return driver.Title.Equals("Dashboard");
        }
    }
}