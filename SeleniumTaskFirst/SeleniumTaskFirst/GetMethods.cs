using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using static SeleniumTaskFirst.PropertyType;

namespace SeleniumTaskFirst
{
    public class GetMethods
    {
        /// <summary>
        /// Returns text from the element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="parameterValue"></param>
        /// <param name="parameterType">default is Id</param>
        public static string GetElementText(string parameterValue, ParameterType? parameterType)
        {
            string text;
            switch (parameterType)
            {
                case ParameterType.Id:
                    text = MainWebDriver.Driver.FindElement(By.Id(parameterValue)).GetAttribute("value");
                    break;

                case ParameterType.Name:
                    text = MainWebDriver.Driver.FindElement(By.Name(parameterValue)).GetAttribute("value");
                    break;

                default:
                    text = MainWebDriver.Driver.FindElement(By.Id(parameterValue)).GetAttribute("value");
                    break;
            }

            return text;
        }

        /// <summary>
        /// Returns text from selected dropdown
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="parameterValue"></param>
        /// <param name="parameterType">default is Id</param>
        public static string GetSelectedDropDownText(string parameterValue, ParameterType? parameterType)
        {
            string text;

            switch (parameterType)
            {
                case ParameterType.Id:
                    text = new SelectElement(MainWebDriver.Driver.FindElement(By.Id(parameterValue))).SelectedOption.Text;
                    break;

                case ParameterType.Name:
                    text =  new SelectElement(MainWebDriver.Driver.FindElement(By.Name(parameterValue))).SelectedOption.Text;
                    break;

                default:
                    text =  new SelectElement(MainWebDriver.Driver.FindElement(By.Id(parameterValue))).SelectedOption.Text;
                    break;
            }

            return text;
        }
    }
}
