using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace TestDemoOnNUnit1
{
    public class Tests
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
            driver.Url = "https://demoqa.com/alerts";

            //to open new tab 
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(3000);
            //driver.FindElement(By.CssSelector("button#confirmButton")).Click();
            IWebElement ele = driver.FindElement(By.CssSelector("button#confirmButton"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].Click()", ele);

            
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
            javaScriptExecutor.ExecuteScript("arguments[0].click()", ele);


            string alertText = driver.SwitchTo().Alert().Text;

            StringAssert.Contains(alertText, str);
            if (alertText == "Do you confirm action?")
            {
                driver.SwitchTo().Alert().Accept();
                //driver.SwitchTo().Alert().Dismiss();
            }
            else
            { 
            
            }
            // For Prompt Alert 
           
                driver.FindElement(By.CssSelector("button#promtButton")).Click();
            driver.SwitchTo().Alert().SendKeys("accepted");
            driver.SwitchTo().Alert().Accept();


            //String title = webDriver.Title;
            //webDriver.FindElement(By.XPath("//textarea[1]")).SendKeys(title);
            //Thread.Sleep(3000);
            //webDriver.FindElement(By.XPath("//textarea[1]")).Click();
            //Thread.Sleep(3000);
            //webDriver.Navigate().Back();
            //Thread.Sleep(3000);
            //webDriver.Navigate().Refresh();
            //Thread.Sleep(3000);
            //webDriver.Navigate().Forward();
            //Assert.Pass();

            IWebElement element = driver.FindElement(By.XPath("//textarea[1]")); 
            Boolean status = element.Displayed;

            if (status)
            {

            }
            else
            { 
            
            }

            IWebElement element1 = driver.FindElement(By.XPath("//textarea[1]")); 
            String tagName = element1.TagName;

            if (tagName != null)
            {

            }
            else
            { 
            
            }
            IWebElement dropdown = driver.FindElement(By.XPath("//span[@role='combobox']"));
            SelectElement s = new SelectElement(dropdown);

        }

        [TearDown]
        public void Stop()
        {
            //webDriver.Close();
        }
    }
}