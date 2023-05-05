using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace TestDemoOnNUnit1
{
    public class Class1
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
            driver.Url = "https://www.geodatasource.com/software/country-region-dropdown-menu-demo";
            Thread.Sleep(3000);

            IWebElement dropdown = driver.FindElement(By.XPath("//div[@class='col-sm-10']//select[@class='form-control gds-cr']"));
            SelectElement s = new SelectElement(dropdown);
            
            s.SelectByText("Slovakia");
            Thread.Sleep(5000);
            s.SelectByValue("Algeria");
            s.SelectByIndex(2);
           

        }
    }
}
