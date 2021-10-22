using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTaskFirst
{
    public class FormPageObject
    {
        private IWebDriver _driver;

        public FormPageObject()
        {
            _driver = MainWebDriver.Driver;
        }

        public IWebElement Title => _driver.FindElement(By.Name("TitleId"));
        public IWebElement Initial => _driver.FindElement(By.Name("Initial"));
        public IWebElement FirstName => _driver.FindElement(By.Id("FirstName"));
        public IWebElement MiddleName => _driver.FindElement(By.Name("MiddleName"));
        public IWebElement SaveButton => _driver.FindElement(By.Name("Save"));

        public void FillForm(string title, string initial, string firstName, string middleName)
        {
            new SelectElement(Title).SelectByText(title);
            Initial.SendKeys(initial);
            FirstName.SendKeys(firstName);
            MiddleName.SendKeys(middleName);

            SaveButton.Click();
        }
    }
}
