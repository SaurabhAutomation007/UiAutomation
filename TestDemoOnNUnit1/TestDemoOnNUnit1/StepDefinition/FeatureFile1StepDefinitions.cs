using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace TestDemoOnNUnit1.StepDefinition
{
    [Binding]
    public class FeatureFile1StepDefinitions
    {
        IWebDriver driver = new EdgeDriver();
       
         [Given(@"Iam is at the Home Page")]
        public void GivenIamIsAtTheHomePage()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/login";
        }
        [Then(@"Is Login page open")]
        public void ThenIsLoginPageOpen()
        {
            if (driver.FindElement(By.CssSelector("button#login")).Displayed)
            {
               
            }
            else
            {
               
            }
            
        }
               

        [When(@"Enter UserName and Password")]
        public void WhenEnterUserNameAndPassword()
        {
            driver.FindElement(By.XPath("//input[@placeholder='UserName']")).SendKeys("Saurabh@1234567890");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Saurabh@1234567890");
            Thread.Sleep(4000);
        }

        [When(@"Click on the Submit button")]
        public void WhenClickOnTheSubmitButton()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@id='login']")).Click();
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            true.Equals(driver.FindElement(By.XPath("//button[text()='Log out']")).Displayed);
        }

        [Given(@"LogOut from the Application")]
        public void GivenLogOutFromTheApplication()
        {
            true.Equals(driver.FindElement(By.XPath("//button[@id='login']")).Displayed);
        }

    }
}
