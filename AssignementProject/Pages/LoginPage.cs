using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignementProject.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public void EnterUsername(string username)
        {
            // driver.FindElement(By.Id("authUser")).SendKeys(username);
            //input[@name='username']
            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(password);

        }
        public void ClickOnLogin()

        {
            driver.FindElement(By.Id("login-button")).Click();
        }
        public string GetInvalidErrorMessage()
        {
            return driver.FindElement(By.XPath("//p[]contains(text(),'Invalid'")).Text;
        }

    }
}
