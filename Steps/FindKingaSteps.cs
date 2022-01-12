using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using TechTalk.SpecFlow;
using ScreenPlayPOC.Locators;
using FluentAssertions; //This library will allow us to make assertions that boa constrictor does not have included

namespace ScreenPlayPOC.Steps
{
    [Binding]
    public class FindKingaSteps
    {
        private IActor _actor;

        public FindKingaSteps(IActor actor)
        {
            _actor = actor;
        }
        [Given]
        public void Given_I_want_to_find_some_info_about_Kinga_Daradics()
        {
            //
        }
        
        [When]
        public void When_I_browse_the_Who_We_Are_section_of_Zenitech_s_website()
        {
            _actor.AttemptsTo(Navigate.ToUrl(ZenitechPage.baseUrl));
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.whatWeDo_tab), IsEqualTo.True());
            _actor.AttemptsTo(Click.On(ZenitechPage.whatWeDo_tab));
        }
        
        [Then]
        public void Then_I_should_be_able_to_find_an_article_about_Kinga()
        {
            //look for the news article about Kinga
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.KingaArticle), IsEqualTo.True());
            _actor.AttemptsTo(Click.On(ZenitechPage.KingaArticle));
        }
        [Then]
        public void Then_The_news_article_should_contain_a_quote_from_Kinga()
        {
            _actor.WaitsUntil(CurrentUrl.FromBrowser(), IsEqualTo.Value(ZenitechPage.newsUrlforKingaValidation));
            _actor.AskingFor(Text.Of(ZenitechPage.articleContent)).Contains(ZenitechPage.kingaQuote);

        }
    }
}
