using OpenQA.Selenium;
using System;

namespace POMProject.Pages
{
    class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement NameInput => driver.FindElement(By.Id("txtUsername"));
        private IWebElement PasswordInput => driver.FindElement(By.Id("txtPassword"));
        private IWebElement LoginButton => driver.FindElement(By.Id("btnLogin"));
        private IWebElement ErrorMessage => driver.FindElement(By.Id("spanMessage"));

        public void OpenLoginPage()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }
        public BasePage Login(string username, string password)
        {
            NameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
            return new BasePage(driver);
        }
        public LoginPage Login(string username)
        {
            NameInput.SendKeys(username);
            LoginButton.Click();
            Console.WriteLine(ErrorMessage.Text);
            return this;
        }

        public bool IsMessageDisplayed(string errorMessage)
        {
            return ErrorMessage.Text.Equals(errorMessage);
        }
    }
}
