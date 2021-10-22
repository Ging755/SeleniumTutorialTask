using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTaskFirst.PageObjects
{
    public class LoginPageObject
    {
        private IWebDriver _driver;

        public LoginPageObject()
        {
            _driver = MainWebDriver.Driver;
        }

        public IWebElement UserName => _driver.FindElement(By.Name("UserName"));
        public IWebElement Password => _driver.FindElement(By.Name("Password"));
        public IWebElement LoginButton => _driver.FindElement(By.Name("Login"));

        public FormPageObject Login(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Submit();

            return new FormPageObject();
        }
    }
}
