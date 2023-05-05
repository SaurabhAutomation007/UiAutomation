using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Demo1
{
    public class MouseAction
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
            //webDriver.Url = "https://cheapoair.com";
            //Thread.Sleep(3000);

            Actions a = new Actions(webDriver);
            ////webDriver.FindElement(By.XPath("(//li[@class='navigation__item'])//a[text()='Customer Support']")).Click();
            //a.MoveToElement(webDriver.FindElement(By.XPath("(//li[@class='navigation__item'])//a[text()='Customer Support']"))).Click().Perform();

            //Thread.Sleep(8000);


            //Drag
            //webDriver.Url = "https://demoqa.com/droppable";
            //a.DragAndDrop((webDriver.FindElement(By.XPath("//div[@id='draggable']")), webDriver.FindElement(By.XPath("//div[@id='droppable']"))).Perform();

        }
    }
}
