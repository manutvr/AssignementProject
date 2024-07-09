
using AssignementProject.Pages;
using AssignementProject.Utility;
using KPMG.AssignementProject.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignementProject.Test
{
    public class LoginTest:AutomationWraper
    {

        //Create static metohod that return object[]

        [Test]

        [TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginTest))]

        public void ValidLoginTest(string username, string password, string expectedTittle)
        {


            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type=\"submit\"]")).Click();

            string actualText = driver.FindElement(By.XPath("//p[text()='Quick Launch']")).Text;
            Assert.That(actualText, Is.EqualTo(expectedTittle));

            
        }
        [Test]

        [TestCaseSource(typeof(DataSource), nameof(DataSource.InValidLoginTest))]
        public void InValidLoginTest(string username, string password, string expectedTittle)
        {


            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type=\"submit\"]")).Click();

            string actualText=driver.FindElement(By.XPath("//p[text()='Invalid credentials']")).Text;
            Assert.That(actualText, Is.EqualTo(expectedTittle));


        }

    }
}
