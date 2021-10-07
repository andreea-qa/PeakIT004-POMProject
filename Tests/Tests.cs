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
            AdminPage adminPage = new AdminPage(driver);
            loginPage.OpenLoginPage();
            loginPage.Login("admin", "admin123");
            Assert.IsTrue(adminPage.IsUserLoggedIn("Paul"));
            adminPage.OpenDashboard();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
