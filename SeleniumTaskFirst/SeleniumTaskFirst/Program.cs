using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTaskFirst
{
    class Program
    {
        //Browser Refrence
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initilize()
        {
            //Naviagte to Google
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Navigated to URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Find cookie confirm button
            IWebElement confirmButton = driver.FindElement(By.Id("L2AGLb"));
            //Click cookie confirm button
            confirmButton?.Click();
            Console.WriteLine("Confirmed cookie button");

            //Find search bar
            IWebElement element = driver.FindElement(By.Name("q"));
            //Send text to search bar
            element.SendKeys("This is Selenium test");
            Console.WriteLine("Text entered in search bar");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
