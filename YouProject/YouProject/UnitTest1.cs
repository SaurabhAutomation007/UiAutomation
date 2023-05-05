using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace YouProject
{
    public class Tests

    {
        IWebDriver webDriver;
        [SetUp]
        public void StartEdge()
        {
            webDriver = new EdgeDriver();
        }

        [Test]
        public void OpenWebSite()
        {
            webDriver.Url = "https://www.google.com";
            Assert.Pass("Open Google Page..");
        }

        [OneTimeTearDown]
        public void StopEdge()
        {
            webDriver.Close();
        }
    }
}