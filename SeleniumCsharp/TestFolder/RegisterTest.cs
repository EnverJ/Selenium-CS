using System;
using SeleniumCsharp.BasePage;
using SeleniumCsharp.Pages;

namespace SeleniumCsharp.Tests
{
	public class RegisterTest: BaseClass
    {

		public HomePage homePage;
		public RegistrationPage registrationPage;
		[Category("Smoke")]
		[Test]
		// verify fucnitonlaity
		public void verifyExsistingRegesterFunctionality() {
			String email = "csfkxls44sf12";
			homePage = new HomePage(driver);
			registrationPage = new RegistrationPage(driver);
            Assert.That(homePage.titleVlaidation, Is.EqualTo("Demo Web Shop"));
			homePage.clickRegisterBtn();
			Assert.That(registrationPage.titleVlaidation, Is.EqualTo("Demo Web Shop. Register"));
			registrationPage.selectGender();
			registrationPage.enterFirstName("sfdsdfds");
			registrationPage.enterLstName("sfsf");
			registrationPage.enterEmail(email+"@gmail.com");
			registrationPage.enterPassword("fdsf@#@#@s");
            registrationPage.enterPasswordConfirm("fdsf@#@#@s");
			registrationPage.clickRegiserBtn();
			String resutl=registrationPage.getSucessMessage();
			Assert.That(resutl, Is.EqualTo("Your registration completed"));
			bool isTrue=registrationPage.isEmalaccoutnDisplayed(email);
			Assert.IsTrue(isTrue);
        }
		[Category("Unit test")]
		[Test]
		public void verifyLogisDispalyed() {
		}
	}
}

