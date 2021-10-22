using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTaskFirst.PageObjects;
using System;
using System.Threading;
using static SeleniumTaskFirst.PropertyType;

namespace SeleniumTaskFirst
{
    class Program
    {

        [SetUp]
        public void Initilize()
        {
            MainWebDriver.Driver = new ChromeDriver();

            //Naviagte to Google
            MainWebDriver.Driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            Console.WriteLine("Navigated to URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Paged Object
            LoginPageObject loginPage = new LoginPageObject();
            var formPage = loginPage.Login("test", "test");
            formPage.FillForm("Mr.", "DM", "Denis", "Vragoalsti");


            /*
            //Selecting Title
            ActionMethods.SelectDropDownValue("Mr.", "TitleId", ParameterType.Name);
            Console.WriteLine("Selected title is " + GetMethods.GetSelectedDropDownText("TitleId", ParameterType.Name));

            //Entering text
            ActionMethods.SendKeysElement("Denis", "FirstName", ParameterType.Id);
            Console.WriteLine("Text from First Name is " + GetMethods.GetElementText("FirstName", ParameterType.Id));

            //Clicking Save button
            ActionMethods.ClickElement("Save", ParameterType.Name);
            */
        }

        [TearDown]
        public void CleanUp()
        {
            //Wait to be able to observe browser actions
            Thread.Sleep(10000);
            MainWebDriver.Driver.Close();
        }
    }
}
