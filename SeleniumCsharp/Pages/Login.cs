using System;
using OpenQA.Selenium;
using SeleniumCsharp.WebDriverExtensions;

namespace SeleniumCsharp.Pages
{
	public class Login
	{
       public static IWebDriver driver;
       public Login(IWebDriver driver)
        {
            Login.driver = driver;
        }

        public string getTtilte()
        {
            return driver.Title;
        }

        // page obejcts

        public static readonly By emailText = By.Id("Email");
        public static readonly By passwordText = By.Id("Password");
        public static readonly By loginBtn = By.XPath("//input[@value='Log in']");

        public  readonly string emailTextValue = "Email Address";
        public readonly string passwordTextValue = "Password";
        public readonly string loginBtnValue = "Login Btn";

        // PAGE METHODS
        public void enterEmail(string email) {
            driver.enterText( emailText,email,emailTextValue);
        }
        public void enterPassword(string password) {
            driver.enterText(passwordText, password, passwordTextValue);
        }
        public void clickLoginBtn() {
            driver.click(loginBtn, loginBtnValue);
        }
    
    }
}

