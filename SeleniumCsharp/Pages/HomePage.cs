using System;
using OpenQA.Selenium;

namespace SeleniumCsharp.Pages
{
	public class HomePage
	{
		public static IWebDriver driver;
		public HomePage(IWebDriver driver)
		{
            HomePage.driver = driver;
		}


		// title checking
		public String titleVlaidation() {
			return driver.Title;
		}
		// page objectss for elements

		public static readonly By registerLink = By.ClassName("ico-register");
		public static readonly By loginLink = By.ClassName("ico-login");

		// page methods
		public void clickRegisterBtn() {
			driver.FindElement(registerLink).Click();
		}

	}
}

