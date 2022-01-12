using Boa.Constrictor.Logging;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ScreenPlayPOC.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        //Here we'll define the way all scenarios/features are handled, we'll have a distinct scenario context for each specific scenario/features as we run them
        private readonly ScenarioContext _scenarioContext;
        public SpecFlowHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario(Order = 0)]
        public void InitializeScreenplay()
        {
            //Here we define an instance of our screenplay actor for each of our scenarios/features. It will start as the actor we define and use tthe "BrowseTheWeb" ability initialises the Selenium Chrome driver.

            var actor = new Actor("Luca", new ConsoleLogger());
            actor.Can(BrowseTheWeb.With(new ChromeDriver()));

            _scenarioContext.ScenarioContainer.RegisterInstanceAs(actor);
        }

        [AfterScenario()]
        public void QuitBrowser()
        {
            //After each scenario we'll quit the webdriver and start an new instance
            var actor = _scenarioContext.ScenarioContainer.Resolve<Actor>();
            actor.AttemptsTo(QuitWebDriver.ForBrowser());
        }
    }
}
