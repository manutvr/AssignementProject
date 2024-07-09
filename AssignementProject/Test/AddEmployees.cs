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
    public class AddEmployees : AutomationWraper
    {

        //Create static metohod that return object[]

        [Test]

        [TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginTest))]

        public void ValidLoginTest(string username, string password, string expectedTittle)
        {


            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type=\"submit\"]")).Click();
            
            

            //Assert.That(actualTitle, Is.EqualTo(expectedTittle));
        }
    }
}
