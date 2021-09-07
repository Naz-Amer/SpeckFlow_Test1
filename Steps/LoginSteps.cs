using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProject1.Pages;

namespace TestProject1.Steps
{
    [Binding]
    public class LoginSteps
    {
        // Anti - Context Injection code = 100% wrong 

        private LoginPage loginPage = null;

        [Given(@"I lunch application")]
        public void GivenILunchApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://secure.smartbearsoftware.com/samples/TestComplete12/WebOrders/Login.aspx?");
            loginPage = new LoginPage(webDriver);

        }

        [Given(@"I enter the folowwing details")]
        public void GivenIEnterTheFolowwingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.Username,(string)data.Password);
        }
        
        [When(@"I clcik login button")]
        public void WhenIClcikLoginButton()
        {
            loginPage.loginbutton.Click();
        }
        
        [Then(@"I should see WebOrders Text")]
        public void ThenIShouldSeeWebOrdersText()
        {
            Assert.That(loginPage.webtext(),Is.True);
        }

        
    }
}
