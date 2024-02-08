using System;
using SeleniumCsharp.BasePage;
using SeleniumCsharp.Pages;
using SeleniumCsharp.WebDriverExtensions;

namespace SeleniumCsharp.Tests
{
	
	public class LoginTest: BaseClass
    {

		public HomePage homePage;
		public Login loginPage;
        [Test]
		[Category("Smoke")]
		public void loginMethod() {
			homePage = new HomePage(driver);
			loginPage = new Login(driver);

			string emailValue = "csfkxls44sf12@gmail.com";
			string passwordValue = "fdsf@#@#@s";
			homePage.clickLoginBtn();
			string title = homePage.titleVlaidation();
			Assert.That(title, Is.EqualTo("Demo Web Shop. Login"));
			loginPage.clickLoginBtn();
			loginPage.enterEmail(emailValue);
			loginPage.enterPassword(passwordValue);
			loginPage.clickLoginBtn();
		}
	}
}

