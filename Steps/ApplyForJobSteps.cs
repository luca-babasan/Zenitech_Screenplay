using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using TechTalk.SpecFlow;
using ScreenPlayPOC.Locators;
using System.Threading;

namespace ScreenPlayPOC.Steps
{
    [Binding]
    public class ApplyForJobSteps
    {
        //initialize the screenplay actor// we will need this in every step definition, to be able to call the actor+abilities
        private IActor _actor;

        //This "ApplyForJobSteps" name needs to be identical to the public class name it's part of, in this case "public class ApplyForJobSteps"
        public ApplyForJobSteps(IActor actor)
        {
            _actor = actor;
        }
        //end of initialisation, just copy lines 13 and 16-19 to a new step definition and replace "ApplyForJobSteps"

        [Given]
        public void Given_I_am_on_the_Zenitech_webiste()
        {
            _actor.AttemptsTo(Navigate.ToUrl(ZenitechPage.baseUrl));
        }
        
        [Given]
        public void Given_I_browse_through_the_available_jobs()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.JoinUsTab), IsEqualTo.True());
            _actor.AttemptsTo(Click.On(ZenitechPage.JoinUsTab));
        }
        
        [When]
        public void When_I_can_t_find_a_role_that_suits_me()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.sendCVbutton), IsEqualTo.True());
            _actor.AttemptsTo(JavaScriptClick.On(ZenitechPage.sendCVbutton));
            _actor.WaitsUntil(CurrentUrl.FromBrowser(), IsEqualTo.Value(ZenitechPage.CV));
        }
        
        [Then]
        public void Then_I_should_be_able_to_fill_in_a_custom_job_application_form()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.Apply_now),IsEqualTo.True());
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.I_am_interested_in_field, ValuesList.I_am_interested_in_info));
            _actor.AttemptsTo(Click.On(ZenitechPage.location_dropdown));
            _actor.AttemptsTo(Click.On(ZenitechPage.location_Cluj_Napoca));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.full_name_field, ValuesList.full_name_info));
            //We can also add values manually like in the below cases, if we do not want to inject the info from another file
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.email_field, "luca.babasan@zenitech.co.uk"));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.phone_number_field, "0748533618"));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.linkedIn_profile_field, "https://www.linkedin.com/in/babasan-luca-emanuel"));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.github_repo_field, "https://github.com/q2ebanking/boa-constrictor"));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.other_details_field, "Can be persuaded with coffee and cookies"));
            _actor.AttemptsTo(Click.On(ZenitechPage.Apply_now));

            //for the demo we'll set a 4 seconds timeout so we can see what the script did
            Thread.Sleep(4000);
        }
    }
}
