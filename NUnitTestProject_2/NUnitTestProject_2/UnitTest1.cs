

//using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace NUnitTestProject_2
{

    class NUnitDemo_Class
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            //driver = new EdgeDriver();
            var options = new EdgeOptions();
            options.UseChromium = true;
            var driver = new EdgeDriver(options);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_google()
        {
            driver.Url = "https://www.google.com";
            System.Threading.Thread.Sleep(4000);

            IWebElement element = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));

            element.SendKeys("LambdaTest");

            /* Submit the Search */
            element.Submit();

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }

    public class Browser
    {
        //    IWebDriver webDriver;
        //    public void Init_Browser()
        //    {
        //        webDriver = new EdgeDriver();
        //        webDriver.Manage().Window.Maximize();
        //    }
        //    public string Title
        //    {
        //        get { return webDriver.Title; }
        //    }

        //    public void Goto(string url)
        //    {
        //        webDriver.Url = url; 
        //    }

        //    public void Close()
        //    {
        //        webDriver.Quit();
        //    }

        //    public IWebDriver GetDriver
        //    {
        //        get { return webDriver; }
        //    }
        //}


        //public class Tests
        //{

        //    [SetUp]
        //    public void Setup()
        //    {
        //    }

        //    [Test]
        //    public void Test1()
        //    {
        //        Assert.Pass();
        //    }
        //}
    }
}