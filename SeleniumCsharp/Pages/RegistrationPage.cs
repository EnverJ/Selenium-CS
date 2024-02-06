using System;
using OpenQA.Selenium;

namespace SeleniumCsharp.Pages
{
	public class RegistrationPage

	{
        public static IWebDriver driver;
        public RegistrationPage(IWebDriver driver)
		{
            RegistrationPage.driver = driver;
		}

        public String titleVlaidation()
        {
            return driver.Title;
        }

        public static readonly By genderMale=By.XPath("//a[text()='Register']");
        public static readonly By firstName = By.Id("FirstName");
        public static readonly By lastName = By.Id("LastName");
        public static readonly By emailAddress = By.Id("Email");
        public static readonly By passwordBtn = By.Id("Password");
        public static readonly By passwordConfrimBtn = By.Id("ConfirmPassword");
        public static readonly By registerBtn = By.Id("register-button");
        public static readonly By resultMsg = By.XPath("//div[contains(text(),'Your registration completed')]");
        public static readonly By logout = By.Id("ico-logout");


        /*
         PAGE METHODS
         */

        public void selectGender() {
            driver.FindElement(genderMale).Click();
                }

        public void enterFirstName(String value) {
            driver.FindElement(firstName).SendKeys(value);
        }

        public void enterLstName(String value)
        {
            driver.FindElement(lastName).SendKeys(value);
        }

        public void enterEmail(String value)
        {
            driver.FindElement(emailAddress).SendKeys(value);
        }

        public void enterPassword(String value)
        {
            driver.FindElement(passwordBtn).SendKeys(value);
        }
        public void enterPasswordConfirm(String value)
        {
            driver.FindElement(passwordConfrimBtn).SendKeys(value);
        }
        public void clickRegiserBtn() {
            driver.FindElement(registerBtn).Click();
        }

        public String getSucessMessage() {
            return driver.FindElement(resultMsg).Text;
        }
        public bool isEmalaccoutnDisplayed(String email) {
            return driver.FindElement(By.LinkText(email + "@gmail.com")).Displayed;
        }
        public void logOut() {
            driver.FindElement(logout).Click();
        }
    }
}

