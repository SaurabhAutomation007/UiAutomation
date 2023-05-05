using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemoOnNUnit1
{
    public class LoginFunctionality
    {
        IWebDriver driver = new EdgeDriver();

        [SetUp]
        public void Start()
        {
           
            driver.Url = "https://demoqa.com/login";
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void OpenWebBrowder()
        {
            if (driver.FindElement(By.CssSelector("button#login")).Displayed)
            {
                driver.FindElement(By.XPath("//input[@placeholder='UserName']")).SendKeys("Saurabh@1234567890");
                driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Saurabh@1234567890");
                Thread.Sleep(4000);

                driver.FindElement(By.XPath("//button[@id='login']")).Click();

                if (driver.FindElement(By.XPath("//button[text()='Log out']")).Displayed)
                {
                    driver.FindElement(By.XPath("//button[text()='Log out']")).Click();
                }
                else { }

                if (driver.FindElement(By.XPath("//button[@id='login']")).Displayed)
                {
                    Assert.Pass();
                }
            }
            else
            { }



        }


        }
}
