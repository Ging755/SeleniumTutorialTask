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
        public static void SendKeysElement(IWebDriver driver,string value, string parameterValue, ParameterType? parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Id:
                    driver.FindElement(By.Id(parameterValue)).SendKeys(value);
                    break;

                case ParameterType.Name:
                    driver.FindElement(By.Name(parameterValue)).SendKeys(value);
                    break;

                default:
                    driver.FindElement(By.Id(parameterValue)).SendKeys(value);
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
        public static void ClickElement(IWebDriver driver, string parameterValue, ParameterType? parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Id:
                    driver.FindElement(By.Id(parameterValue)).Click();
                    break;

                case ParameterType.Name:
                    driver.FindElement(By.Name(parameterValue)).Click();
                    break;

                default:
                    driver.FindElement(By.Id(parameterValue)).Click();
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
        public static void SelectDropDownValue(IWebDriver driver, string value, string parameterValue, ParameterType? parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.Id:
                    new SelectElement(driver.FindElement(By.Id(parameterValue))).SelectByText(value);
                    break;

                case ParameterType.Name:
                    new SelectElement(driver.FindElement(By.Name(parameterValue))).SelectByText(value);
                    break;

                default:
                    new SelectElement(driver.FindElement(By.Id(parameterValue))).SelectByText(value);
                    break;
            }
        }
    }
}
