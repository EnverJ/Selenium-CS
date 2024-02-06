using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        
    }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}

