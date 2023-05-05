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
            driver.Url = "https://demoqa.com/selectable";
            Thread.Sleep(3000);


            Actions a = new Actions(driver);

            a.KeyDown(Keys.Control)
                .Click(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[1]")))
                .Click(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[2]")))
                .Click(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[3]")))
                .KeyUp(Keys.Control)
                .Build()
                .Perform();


        }
    }
}
