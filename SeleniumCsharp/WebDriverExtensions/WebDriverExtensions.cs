using System;
using NLog;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using Logger = NLog.Logger;

namespace SeleniumCsharp.WebDriverExtensions
{
	public static class WebDriverExtensions
	{
        public static Logger logger = LogManager.GetCurrentClassLogger();
		// commonnn methods or re-usable methods
		public static void enterText(this IWebDriver driver,  By locator, String value,string name) {
            try
            {
                IWebElement ele = driver.FindElement(locator);

                if (ele.Displayed && ele.Enabled)
                {
                    logger.Info("Enter {0},{1}", name, value);
                    ele.Clear();
                    ele.SendKeys(value);
                }
            }
            catch (Exception e)
            {
                logger.Info("Unable to enter {0}", name+" : "+e.Message);
                throw;
            }
			
		}


		// click button, radio button and checkboxes  
        public static void click(this IWebDriver driver, By locator,string nameoElement)
        {

            try
            {
                IWebElement ele = driver.FindElement(locator);

                if (ele.Displayed && ele.Enabled)
                {
                    logger.Info("Click on {0}", nameoElement);
                    ele.Click();
                }
            }
            catch (Exception e)
            {
                logger.Info("unable to click {0}", nameoElement + " : " + e.Message);
            }
            
        }

        public static bool siElementDisplayed(this IWebDriver driver, By locator, string nameOfElement)
        {
            IWebElement ele = driver.FindElement(locator);

            if (ele.Displayed)
            {
                logger.Info(nameOfElement + " is dipalyed");
                return true;
            }
            return true;
        }

        public static string getText(this IWebDriver driver,By locator) {
            IWebElement ele = driver.FindElement(locator);
            string text="";
            if (ele.Displayed) {
                text = ele.Text;
            }
            return text;
        }

        public static bool getTextWithValueD(this IWebDriver driver, string value)
        {
           
            IWebElement ele = driver.FindElement(By.LinkText(value + "@gmail.com"));
            if (ele.Displayed)
            {
                return true;
            }
            return true;

        }
        public static void isAlertPresent()
        {
        }

        public static void selectByVisibleText()
        {
        }
    }
}

