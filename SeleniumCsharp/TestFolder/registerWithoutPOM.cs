using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCsharp
{
    public class Tests1
    {
        private WebDriver driver;
        private string email = "week83435";

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            string title = driver.Title;
            Console.WriteLine("This is home page title: " + title);
            Assert.That(title, Is.EqualTo("Demo Web Shop"));

            driver.FindElement(By.XPath("//a[text()='Register']")).Click();
            Assert.That(driver.Title, Is.EqualTo("Demo Web Shop. Register"));

            driver.FindElement(By.Id("FirstName")).SendKeys("week8");
            driver.FindElement(By.Id("LastName")).SendKeys("week8343");
            driver.FindElement(By.Id("Email")).SendKeys(email + "@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("week8343$");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("week8343$");
            driver.FindElement(By.Id("register-button")).Click();

            string successMsg = driver.FindElement(By.XPath("//div[contains(text(),'Your registration completed')]")).Text;
            Assert.That(successMsg, Is.EqualTo("Your registration completed"));

            IWebElement emailValidation = driver.FindElement(By.LinkText(email + "@gmail.com"));
            Assert.IsTrue(emailValidation.Displayed, "The email validation element should be displayed.");
            driver.FindElement(By.ClassName("ico-logout")).Click();

            Console.WriteLine("Welcome to selenium c#");
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
