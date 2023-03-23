using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayAuto.Selenium.Infra
{
    public static class Extensions
    {
        public static IWebElement CustomFindElement(this IWebElement webElement, By by)
        {
            try
            {
                return webElement.FindElement(by);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool CustomClick(this IWebElement webElement)
        {
            try
            {
                webElement.Click();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool CustomSendKeys(this IWebElement webElement, string value)
        {
            try
            {
                webElement.SendKeys(value);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool CustomFrame(this ITargetLocator targetLocator, string frameName)
        {
            try
            {
                targetLocator.Frame(frameName);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
