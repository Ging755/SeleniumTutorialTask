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

            driver.Navigate().GoToUrl("http://google.com");
        }
    }
}
