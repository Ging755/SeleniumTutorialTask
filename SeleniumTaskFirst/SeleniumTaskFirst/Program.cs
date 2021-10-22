using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using static SeleniumTaskFirst.PropertyType;

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
            //Selecting Title
            ActionMethods.SelectDropDownValue(driver, "Mr.", "TitleId", ParameterType.Name);
            Console.WriteLine("Selected title is " + GetMethods.GetSelectedDropDownText(driver, "TitleId", ParameterType.Name));

            //Entering text
            ActionMethods.SendKeysElement(driver, "Denis", "FirstName", ParameterType.Id);
            Console.WriteLine("Text from First Name is " + GetMethods.GetElementText(driver, "FirstName", ParameterType.Id));

            //Clicking Save button
            ActionMethods.ClickElement(driver, "Save", ParameterType.Name);
        }

        [TearDown]
        public void CleanUp()
        {
            //Wait to be able to observe browser actions
            Thread.Sleep(10000);
            driver.Close();
        }
    }
}
