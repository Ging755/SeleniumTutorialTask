using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using static SeleniumTaskFirst.PropertyType;

namespace SeleniumTaskFirst
{
    public class ActionMethods
    {

        /// <summary>
        /// Send keys to element.
        /// example: send keys (Text) to a input element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="value"></param>
        /// <param name="parameterValue"></param>
        /// <param name="parameterType">default is Id</param>
        public static void SendKeysElement(string value, string parameterValue, ParameterType? parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Id:
                    MainWebDriver.Driver.FindElement(By.Id(parameterValue)).SendKeys(value);
                    break;

                case ParameterType.Name:
                    MainWebDriver.Driver.FindElement(By.Name(parameterValue)).SendKeys(value);
                    break;

                default:
                    MainWebDriver.Driver.FindElement(By.Id(parameterValue)).SendKeys(value);
                    break;
            }
        }

        /// <summary>
        /// Click element.
        /// example: click a button
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="parameterValue"></param>
        /// <param name="parameterType">default is Id</param>
        public static void ClickElement(string parameterValue, ParameterType? parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Id:
                    MainWebDriver.Driver.FindElement(By.Id(parameterValue)).Click();
                    break;

                case ParameterType.Name:
                    MainWebDriver.Driver.FindElement(By.Name(parameterValue)).Click();
                    break;

                default:
                    MainWebDriver.Driver.FindElement(By.Id(parameterValue)).Click();
                    break;
            }
        }

        /// <summary>
        /// Selected value from a dropdown.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="value"></param>
        /// <param name="parameterValue"></param>
        /// <param name="parameterType">default is Id</param>
        public static void SelectDropDownValue(string value, string parameterValue, ParameterType? parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Id:
                    new SelectElement(MainWebDriver.Driver.FindElement(By.Id(parameterValue))).SelectByText(value);
                    break;

                case ParameterType.Name:
                    new SelectElement(MainWebDriver.Driver.FindElement(By.Name(parameterValue))).SelectByText(value);
                    break;

                default:
                    new SelectElement(MainWebDriver.Driver.FindElement(By.Id(parameterValue))).SelectByText(value);
                    break;
            }
        }
    }
}
