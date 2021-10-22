using OpenQA.Selenium;
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
        public IWebElement FirstName => _driver.FindElement(By.Id("FirstName"));
        public IWebElement SaveButton => _driver.FindElement(By.Name("Save"));
    }
}
