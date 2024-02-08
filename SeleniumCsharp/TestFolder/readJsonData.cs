using System;
using System.Text.Json;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SeleniumCsharp.BasePage;
using SeleniumCsharp.dataModelforJson;

namespace SeleniumCsharp
{
	public class readJsonData : BaseClass
	{
        [Test]
        public void ReadJsonDataMultipleObjects() {
            RegisterList userData = JsonConvert.DeserializeObject<RegisterList>(File.ReadAllText(@"/Users/enverjume/Projects/SeleniumCsharp/SeleniumCsharp/JsonData/registerData.json"));

            for (int i=0;i<userData.Register.Count;i++)
            {
                string fname = userData.Register[i].firstName.ToString();
                string lname = userData.Register[i].lastName.ToString();
                string mEmail = userData.Register[i].Email.ToString();
                string mPassowrd = userData.Register[i].password.ToString();

                Console.WriteLine("===================");
                Console.WriteLine(fname+", " +lname+", "+mEmail+", "+mPassowrd);
            }



        }




		[Test]
		public void testMethod1()
		{
			string readDatFromPath = File.ReadAllText(@"/Users/enverjume/Projects/SeleniumCsharp/SeleniumCsharp/JsonData/userData.json");
			var registerData = System.Text.Json.JsonSerializer.Deserialize<registerDataModel>(readDatFromPath);
			Console.WriteLine(registerData.firstName);
            Console.WriteLine(registerData.lastName);
            Console.WriteLine(registerData.Email);
            Console.WriteLine(registerData.password);


            string title = driver.Title;
            Console.WriteLine("This is home page title: " + title);
            Assert.That(title, Is.EqualTo("Demo Web Shop"));

            driver.FindElement(By.XPath("//a[text()='Register']")).Click();
            Assert.That(driver.Title, Is.EqualTo("Demo Web Shop. Register"));

            driver.FindElement(By.Id("FirstName")).SendKeys(registerData.firstName);
            driver.FindElement(By.Id("LastName")).SendKeys(registerData.lastName);
            driver.FindElement(By.Id("Email")).SendKeys(registerData.password + "@gmail.com");
            driver.FindElement(By.Id("Password")).SendKeys(registerData.password);
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys(registerData.password);
            driver.FindElement(By.Id("register-button")).Click();

            string successMsg = driver.FindElement(By.XPath("//div[contains(text(),'Your registration completed')]")).Text;
            Assert.That(successMsg, Is.EqualTo("Your registration completed"));

            IWebElement emailValidation = driver.FindElement(By.LinkText(registerData.password + "@gmail.com"));
            Assert.IsTrue(emailValidation.Displayed, "The email validation element should be displayed.");
            driver.FindElement(By.ClassName("ico-logout")).Click();

            Console.WriteLine("Welcome to selenium c#");


        }
    }
    
}

