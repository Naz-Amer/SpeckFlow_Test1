
using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        // UI Elements
        public IWebElement txtusername => WebDriver.FindElement(By.XPath("//input[@id='ctl00_MainContent_username']"));
        public IWebElement txtpassword => WebDriver.FindElement(By.XPath("//input[@id='ctl00_MainContent_password']"));
        public IWebElement loginbutton => WebDriver.FindElement(By.XPath("//input[@id='ctl00_MainContent_login_button']"));
        public IWebElement txtwebtext => WebDriver.FindElement(By.XPath("//h1[normalize-space()='Web Orders']"));


        //public void ClickLogin() => txtusername.SendKeys("Tester");

        public void Login(string userName, string password)
        {
            txtusername.SendKeys(userName);
            txtpassword.SendKeys(password);
        }

        public void ClickLoginButton() => loginbutton.Click();
        public bool webtext() => txtwebtext.Displayed;
    }
}
