using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using TechTalk.SpecFlow;
using ScreenPlayPOC.Locators;
using System.Threading;
using OpenQA.Selenium.Support;
using System.Collections.Generic;
using System;

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
        public void Given_I_want_to_see_the_available_QA_jobs_on_the_Zenitech_website()
        {
            _actor.AttemptsTo(Navigate.ToUrl(ZenitechPage.baseUrl));
        }
        
        [When]
        public void When_I_visit_the_Careers_tab_of_the_website()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.CareersTab), IsEqualTo.True());
            _actor.AttemptsTo(Click.On(ZenitechPage.CareersTab));
        }

        [Then]
        public void Then_I_should_be_able_to_see_the_available_jobs_for_QA_Engineers()
        {
            //_actor.WaitsUntil(Appearance.Of(ZenitechPage.SearchLocations), IsEqualTo.True());
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.SearchField, "QA"));
            _actor.AttemptsTo(Click.On(ZenitechPage.SearchButton));
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.QAJobs), IsEqualTo.True());
            _actor.AsksFor(Text.Of(ZenitechPage.FirstJob));
            _actor.AsksFor(Text.Of(ZenitechPage.SecondJob));
        }    
    }
}
