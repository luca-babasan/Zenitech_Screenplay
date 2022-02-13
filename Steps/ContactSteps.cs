using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using TechTalk.SpecFlow;
using ScreenPlayPOC.Locators;
using System.Threading;

namespace ScreenPlayPOC.Steps
{
    [Binding]
    public class ContactSteps
    {
        //initialize the screenplay actor// we will need this in every step definition, to be able to call the actor+abilities
        private IActor _actor;

        //This "ContactSteps" name needs to be identical to the public class name it's part of, in this case "public class ContactSteps"
        public ContactSteps(IActor actor)
        {
            _actor = actor;
        }
        //end of initialisation, just copy lines 13 and 16-19 to a new step definition and replace "ContactSteps" with the new scenario step name

        [Given]
        public void Given_I_am_on_the_Zenitech_webiste()
        {
            _actor.AttemptsTo(Navigate.ToUrl(ZenitechPage.baseUrl));
        }
       
        [When]
        public void When_I_Wish_To_Contact_The_Company()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.ContactTab), IsEqualTo.True());
            _actor.AttemptsTo(Click.On(ZenitechPage.ContactTab));
        }
        
        [Then]
        public void Then_I_Should_Be_Able_To_Fill_In_A_Form()
        {
            _actor.WaitsUntil(Appearance.Of(ZenitechPage.Message_field),IsEqualTo.True());
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.Country_field, ValuesList.Country));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.Phone_field, ValuesList.Phone));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.First_name_field, ValuesList.First_name));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.Last_name_field, ValuesList.Last_name));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.email_field, "luca.babasan@zenitech.co.uk"));
            _actor.AttemptsTo(SendKeys.To(ZenitechPage.Message_field, ValuesList.Message));
            _actor.AttemptsTo(Click.On(ZenitechPage.Send_button));

            //for the demo we'll set a 4 seconds timeout so we can see what the script did (really bad practice, never use Thread.Sleep, ewww)
            Thread.Sleep(4000);
        }
    }
}
