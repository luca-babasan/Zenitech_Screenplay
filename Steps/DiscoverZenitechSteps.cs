using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using TechTalk.SpecFlow;
using ScreenPlayPOC.Locators;
using System.Threading;

namespace ScreenPlayPOC.Steps
{
    [Binding]
    public sealed class DiscoverZenitechSteps
    {
        private IActor _actor;

        public DiscoverZenitechSteps(IActor actor)
        {
            _actor = actor;
        }
        [Given]
        public void Given_I_want_to_know_more_about_Zenitech()
        {
            //
        }
        
        [When]
        public void When_I_visit_their_webiste()
        {
            //ZenitechPage.baseUrl is defined in Locators folder -> Zenitech
            _actor.AttemptsTo(Navigate.ToUrl(ZenitechPage.baseUrl));
        }
        
        [Then]
        public void Then_I_should_see_a_Who_We_Are_section()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.WhoWeAre_section), IsEqualTo.True());
            _actor.AttemptsTo(Click.On(ZenitechPage.WhoWeAre_section));
            //for the demo we'll set a 4 seconds timeout so we can see what the script did
            Thread.Sleep(4000);
        }
    }
}
