using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Demo1
{
    public class Tests
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
           
            webDriver.Url = "https://demoqa.com/alerts";
            Thread.Sleep(3000);

            webDriver.FindElement(By.CssSelector("button#confirmButton")).Click();
            Thread.Sleep(2000);
           String text = webDriver.SwitchTo().Alert().Text;
            string str = "Do you";
            StringAssert.Contains(str, text);

            Assert.AreEqual(str, text);


            if (text == "Do you confirm action?")
            { }
            else
            { }
           
            webDriver.SwitchTo().Alert().Dismiss();


           //Thread.Sleep(3000);

           //webDriver.FindElement(By.XPath("//textarea[@class='gLFyf']")).Clear();
           //webDriver.FindElement(By.XPath("//textarea[@class='gLFyf']")).SendKeys("facebook");


           IWebElement ele = webDriver.FindElement(By.XPath("//button[text()='Click Me']"));
            Boolean status = ele.Displayed;

            if (ele.Displayed)
            { 
            
            }
            else { }

           


            webDriver.Navigate().Back();
            Thread.Sleep(3000);
            webDriver.Navigate().Forward();
            //Assert.Pass();
        }

        [TearDown]
        public void Stop()
        {
            webDriver.Close();
        }
    }
}