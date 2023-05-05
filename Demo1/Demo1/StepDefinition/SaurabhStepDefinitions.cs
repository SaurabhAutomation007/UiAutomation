using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using TechTalk.SpecFlow;

namespace Demo1
{
    [Binding]
    public class SaurabhStepDefinitions
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
            if (driver.FindElement(By.XPath("//button[text()='Login']")).Displayed)
            {

            }
            else { }
        }

        [When(@"Enter UserName and Password")]
        public void WhenEnterUserNameAndPassword()
        {
            driver.FindElement(By.XPath("//input[@placeholder='UserName']")).SendKeys("Saurabh@1234567890");
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("Saurabh@1234567890"); 
        }

        [When(@"Click on the Submit button")]
        public void WhenClickOnTheSubmitButton()
        {
            driver.FindElement(By.XPath("//button[text()='Login']")).Click();
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            true.Equals(driver.FindElement(By.XPath("//button[text()='Log out']")));
        }

        [Given(@"LogOut from the Application")]
        public void GivenLogOutFromTheApplication()
        {
            driver.FindElement(By.XPath("//button[text()='Log out']")).Click();
            Thread.Sleep(3000);

            if (driver.FindElement(By.XPath("//button[text()='Login']")).Displayed)
            { 
            
            }
        }
    }
}
