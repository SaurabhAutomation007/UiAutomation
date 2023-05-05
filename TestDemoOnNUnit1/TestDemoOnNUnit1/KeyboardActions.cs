using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace TestDemoOnNUnit1
{
    public class KeyboardActions
    {
        IWebDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void OpenWebBrowder()
        {
            string str = "your name";
            driver.Url = "https://demoqa.com/selectable";
            Thread.Sleep(5000);
            Actions a = new Actions(driver);
            a.KeyDown(Keys.Control)
                .Click(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[1]")))
                .Click(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[3]")))
                .Click(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[4]")))
                .KeyUp(Keys.Control)
                .Build()
                .Perform();

            Thread.Sleep(4000);
            driver.Quit();
        }

        }
    }




























//a.KeyDown(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[1])")),Keys.Control)
//    .KeyDown(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[2])")), Keys.Control)
//    .KeyUp(driver.FindElement(By.XPath("//ul[@id='verticalListContainer']/li[3])")), Keys.Control)