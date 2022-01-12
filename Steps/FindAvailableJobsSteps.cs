using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using TechTalk.SpecFlow;
using ScreenPlayPOC.Locators;
using System.Threading;

namespace ScreenPlayPOC.Steps
{
    [Binding]
    public class FindAvailableJobsSteps
    {
        private IActor _actor;

        public FindAvailableJobsSteps(IActor actor)
        {
            _actor = actor;
        }
        [Given]
        public void Given_I_want_to_see_the_available_jobs_on_the_Zenitech_website()
        {
            _actor.AttemptsTo(Navigate.ToUrl(ZenitechPage.baseUrl));
        }
        
        [When]
        public void When_I_visit_the_Join_Us_section_of_the_website()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.JoinUsTab), IsEqualTo.True());
            _actor.AttemptsTo(Click.On(ZenitechPage.JoinUsTab));
        }
        
        [Then]
        public void Then_I_should_be_able_to_see_the_available_jobs_from_Cluj_Napoca()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.Cluj_NapocaJobs), IsEqualTo.True());
            _actor.AskingFor(Text.Of(ZenitechPage.Cluj_NapocaJobs));
        }
    }
}
