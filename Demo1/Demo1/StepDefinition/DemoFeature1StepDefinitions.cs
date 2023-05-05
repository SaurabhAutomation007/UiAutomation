using System;
using TechTalk.SpecFlow;

namespace Demo1.StepDefinition
{
    [Binding]
    public class DemoFeature1StepDefinitions
    {
        [Given(@"Open Browser")]
        public void GivenOpenBrowser()
        {
            throw new PendingStepException();
        }

        [When(@"enter url")]
        public void WhenEnterUrl()
        {
            throw new PendingStepException();
        }

        [Then(@"url navigation")]
        public void ThenUrlNavigation()
        {
            throw new PendingStepException();
        }
    }
}
