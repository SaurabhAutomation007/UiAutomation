using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Alerts
    {
        IWebDriver webDriver;
        [SetUp]
        public void Start()
        {
            webDriver = new EdgeDriver();
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void OpenWebSite()
        {
            webDriver.Url = "https://demoqa.com/buttons";
            Thread.Sleep(3000);

            //Thread.Sleep(3000);

            //webDriver.FindElement(By.XPath("//textarea[@class='gLFyf']")).Clear();
            //webDriver.FindElement(By.XPath("//textarea[@class='gLFyf']")).SendKeys("facebook");


            IWebElement ele = webDriver.FindElement(By.XPath("//button[text()='Click Me']"));
            Boolean status = ele.Displayed;

            if (ele.Displayed)
            {
            }
            else { }

            //IWebElement element = Wedriver.FindElement(By.XPath("xpath of Webelement"));
            //String tagName = element.TagName;

            //String title = webDriver.Title;
            //if (title == "Google")
            //{

            //}
            //else
            //{

            //}


            webDriver.Navigate().Back();
            Thread.Sleep(3000);
            webDriver.Navigate().Forward();
            //Assert.Pass();
        }
    }
}
