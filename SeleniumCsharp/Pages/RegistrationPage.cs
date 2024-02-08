using System;
using OpenQA.Selenium;
using SeleniumCsharp.WebDriverExtensions;

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



        public readonly string genderMaleValue = "Gender";
        public readonly string loginLinkValue = "Login Link";

        public readonly string firstNameValue = "first name";
        public readonly string lastNameValue = "Laast name";

        public readonly string emailAddressValue = "email Address";
        public readonly string passwordBtnValue = "password";

        public readonly string passwordConfirmValue = "password C";
        public readonly string registerValue = "Register Link";

        public readonly string resultmsgValue = "result message";
        public readonly string logoutValue = "log out";


        /*
         PAGE METHODS
         */

        public void selectGender() {
            driver.click(genderMale,genderMaleValue);
                }

        public void enterFirstName(String value) {
            driver.enterText(firstName,value,firstNameValue);
        }

        public void enterLstName(String value)
        {
            driver.enterText(lastName,value,lastNameValue);
        }

        public void enterEmail(String value)
        {
            driver.enterText(emailAddress,value,emailAddressValue);
        }

        public void enterPassword(String value)
        {
            driver.enterText(passwordBtn,value,passwordBtnValue);
        }
        public void enterPasswordConfirm(String value)
        {
            driver.enterText(passwordConfrimBtn,value,passwordConfirmValue);
        }
        public void clickRegiserBtn() {
            driver.click(registerBtn,registerValue);
        }

        public String getSucessMessage() {
            return driver.getText(resultMsg);
        }
        public bool isEmalaccoutnDisplayed(String email)
        {
            return driver.getTextWithValueD(email);
        }
        public void logOut() {
            driver.click(logout,logoutValue);
        }
    }
}

