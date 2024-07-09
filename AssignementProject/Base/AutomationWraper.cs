using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPMG.AssignementProject.Base;


namespace KPMG.AssignementProject.Base
{

    public class AutomationWraper
    {
        protected IWebDriver driver;

        [SetUp]
        public void BeforeMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        }

        [TearDown]
        public void AfterMethod()
        {
            driver.Dispose();

        }
    }
}

