using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTaskFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Browser Refrence
            IWebDriver driver = new ChromeDriver();

            //Naviagte to Google
            driver.Navigate().GoToUrl("http://google.com");

            //Find cookie confirm button
            IWebElement confirmButton = driver.FindElement(By.Id("L2AGLb"));
            //Click cookie confirm button
            confirmButton?.Click();

            //Find search bar
            IWebElement element = driver.FindElement(By.Name("q"));

            element.SendKeys("This is Selenium test");
        }
    }
}
