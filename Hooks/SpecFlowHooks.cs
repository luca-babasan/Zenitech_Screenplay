using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;

namespace ScreenPlayPOC.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        //Here we'll define the way all scenarios/features are handled, we'll have a distinct scenario context for each specific scenario/features as we run them
        private readonly ScenarioContext _scenarioContext;
        private IActor actor;

        public SpecFlowHooks(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
        }

        [BeforeScenario(Order = 0)]
        public void InitializeScreenplay()
        {


            ChromeOptions chromeOptions = new ChromeOptions();

            //chromeOptions.AddArgument("headless");
            chromeOptions.AddArgument("no-sandbox"); // needed to run in docker, as default user is root
            //chromeOptions.AddArgument("disable-gpu");
            //chromeOptions.AddArgument("disable-dev-shm-usage");
            //chromeOptions.DebuggerAddress = "127.0.0.1:9222";

            //-------------------------------------
            //Here we define an instance of our screenplay actor for each of our scenarios/features. 
            //It will start as the actor we define and use the "BrowseTheWeb" ability initialises the Selenium Chrome driver.
            //it creates a new instance of the screenplay actor and new webdriver before each scenario

            actor = new Actor(name: "QA guy", logger: new ConsoleLogger());
            actor.Can(BrowseTheWeb.With(new ChromeDriver(chromeOptions)));

            actor.Can(SetTimeouts.ToDefaultValues());
            actor.AttemptsTo(MaximizeWindow.ForBrowser());
            //We use a new instance of our actor with browsing ability in each of the scenarios/features we have, in this case we defined [BeforeScenario]
            _scenarioContext.ScenarioContainer.RegisterInstanceAs(actor);
        }

        [AfterScenario]
        public void QuitBrowser()
        {
            //After each scenario we'll quit the webdriver and start an new instance
            actor = _scenarioContext.ScenarioContainer.Resolve<Actor>();
            actor.AttemptsTo(QuitWebDriver.ForBrowser());

        }
    }
}
