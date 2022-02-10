using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using TechTalk.SpecFlow;
using ScreenPlayPOC.Locators;
using FluentAssertions; //This library will allow us to make assertions that boa constrictor does not have included

namespace ScreenPlayPOC.Steps
{
    [Binding]
    public class FindCsabaSteps
    {
        private IActor _actor;

        public FindCsabaSteps(IActor actor)
        {
            _actor = actor;
        }
        [Given]
        public void Given_I_want_to_find_some_info_about_Csaba_Suket()
        {
            _actor.AttemptsTo(Navigate.ToUrl(ZenitechPage.baseUrl));
            _actor.AttemptsTo(Click.On(ZenitechPage.About_section));
        }
        
        [When]
        public void When_I_browse_the_our_people_section_of_the_Zenitech_website()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.Csaba_button),IsEqualTo.True());
            _actor.AttemptsTo(JavaScriptClick.On(ZenitechPage.Csaba_button));
            _actor.WaitsUntil(CurrentUrl.FromBrowser(), IsEqualTo.Value(ZenitechPage.People_section_link));
        }

        [Then]
        public void Then_I_should_be_able_to_find_an_article_about_Csaba()
        {
            //look for the article about Csaba
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.Csaba_article), IsEqualTo.True());
            _actor.AsksFor(Text.Of(ZenitechPage.Csaba_article));
        }
        
    }
}
