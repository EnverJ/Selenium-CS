using System;
using OpenQA.Selenium;
using SeleniumCsharp.WebDriverExtensions;

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

		public readonly string registerLinkValue = "Register Link";
        public readonly string loginLinkValue = "Login Link";

        // page methods
        public void clickRegisterBtn() {
			driver.click(registerLink, registerLinkValue);
		}

        public void clickLoginBtn()
        {
            driver.click(loginLink,loginLinkValue);
        }

    }
}

