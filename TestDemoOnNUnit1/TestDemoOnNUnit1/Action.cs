using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace TestDemoOnNUnit1
{
    public class Action
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
            driver.Url = "https://www.cheapoair.com/";
            Thread.Sleep(3000);


            Actions a = new Actions(driver);

            a.ContextClick(driver.FindElement(By.XPath("//a[text()='Help']"))).Perform();
            Thread.Sleep(5000);

            //a.MoveToElement(driver.FindElement(By.XPath("//div[@class='user-interaction']/li[4]"))).Perform();

            ////driver.FindElement(By.XPath("//li[@class='navigation__item']//a[@class='navigation__link']")).Click();
            Thread.Sleep(2);
            a.MoveToElement(driver.FindElement(By.XPath("//a[text()='Help']"))).Perform();
            a.MoveToElement(driver.FindElement(By.XPath("(//li[@class='navigation__item'])//a[@class='navigation__link']"))).Click().Perform();
            Thread.Sleep(5000);


            //Drag
            //driver.Url = "https://demoqa.com/droppable";
            //a.DragAndDrop(driver.FindElement(By.XPath("//div[@id='draggable']")), driver.FindElement(By.XPath("//div[@id='droppable']"))).Build().Perform();

            //Context click 
            //a.ContextClick(driver.FindElement(By.XPath("//a[text()='Help']"))).Perform();
            //Thread.Sleep(5000);
        }
    }
}
