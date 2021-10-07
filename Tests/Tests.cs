using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMProject.Pages;


namespace POMProject.Tests
{
    [TestFixture]
    class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void NavigateToDashboardPage()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.OpenLoginPage();
            loginPage.Login("admin", "admin123");
            
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
