using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemoOnNUnit1
{
    public class KeyboardAction
    {
        IWebDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void dropDown()
        {
            //string str = "your name";
            //driver.Url = "https://www.google.com/";
            Thread.Sleep(3000);
            //driver.Url = "https://www.google.com/";
            Thread.Sleep(3000);
            Actions a = new Actions(driver);
            Thread.Sleep(3000);

            a.KeyDown(Keys.LeftControl).SendKeys("t").KeyUp(Keys.LeftControl).Build().Perform();

            a.KeyDown(Keys.LeftControl).KeyDown(Keys.LeftShift).SendKeys("a").KeyUp(Keys.LeftShift).KeyUp(Keys.LeftControl).Build().Perform();
            Thread.Sleep(3000);

        }
    }
}
