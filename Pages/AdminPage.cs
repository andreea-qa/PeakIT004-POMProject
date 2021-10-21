using OpenQA.Selenium;

namespace POMProject.Pages
{
    class AdminPage : BasePage
    {
        public AdminPage(IWebDriver driver) : base(driver) {  }
        
        public override bool IsTitleCorrect()
        {
            return driver.Title.Equals("OrangeHRM");
        }
    }
}
