using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace SeleniumCsharp.BasePage
{

	/*
	 * intialize the driver ---setup driver
	 * Reusale mehods
	 * 
	 
	 */
	public class BaseClass
	{
        public static WebDriver driver;
    
        [SetUp]
        public void Init()
        {
           // string baseURL = ConfigurationManager.AppSettings["URL"];
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        
    }
        //public static string getTitle() {
        //}
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}

