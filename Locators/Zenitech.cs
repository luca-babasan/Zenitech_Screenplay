using OpenQA.Selenium;
using Boa.Constrictor.Selenium;
using Boa.Constrictor.Screenplay;

namespace ScreenPlayPOC.Locators
{
    public class ZenitechPage
    {
        public const string baseUrl = "https://zenitech.co.uk/";

        //We use "IWebLocator" to define an elements's locator by : ClassName, CssSelector, Id, LinkText, Name, PartialLinkText, TagName, XPath
        
        //Locators for "Find available QA jobs in Cluj-Napoca" scenario
        public static IWebLocator CareersTab => WebLocator.L(
            "Join Us Tab of the website", //this is the description for the element
            By.LinkText("Careers")); //this is the driver.FindElement.By.Xpath() part.
        public static IWebLocator JobOpeningsBtn => WebLocator.L(
            "Job openings button of the careens page", //this is the description for the element
            By.LinkText("Job openings"));
        public static IWebLocator AllJobsBtn => WebLocator.L(
            "All jobs button of the careens page", //this is the description for the element
            By.LinkText("All jobs"));
        public static IWebLocator QAJobs => WebLocator.L(
            "Available Jobs grid blocks",
            By.Id("block-grid"));
        public static IWebLocator FirstJob => WebLocator.L(
            "Engineer job",
            By.PartialLinkText("Engineer"));
        public static IWebLocator CookiesPopup => WebLocator.L(
            "CookiesPopup",
            By.LinkText("Accept all"));

        //-----------------------------//
        //Locators for "Contact" scenario
        public static IWebLocator ContactTab => WebLocator.L("Contact Tab", By.LinkText("Contact"));
        public static IWebLocator Country_field => WebLocator.L("Country filed of form", By.Name("Country"));
        public static IWebLocator Phone_field => WebLocator.L("Phone field of form", By.Name("Phone"));
        public static IWebLocator First_name_field => WebLocator.L("First name field of form", By.Name("First Name"));
        public static IWebLocator Last_name_field => WebLocator.L("Last name filed of form", By.Name("Last Name"));
        public static IWebLocator email_field => WebLocator.L("Email field of form", By.Name("Email"));
        public static IWebLocator Message_field => WebLocator.L("Message field of form", By.Name("Description"));
        public static IWebLocator Send_button => WebLocator.L("Send form button", By.Id("formsubmit"));
    //-----------------------------//   
    //Locators for "Find Csaba" scenario

        public static IWebLocator About_section => WebLocator.L(
            "About section",
            By.LinkText("About")); 
        public static IWebLocator Csaba_button => WebLocator.L(
            "People Tab",
            By.LinkText("Csaba Suket"));
        public const string People_section_link = "https://zenitech.co.uk/people/#csaba";
        
        public static IWebLocator Csaba_article => WebLocator.L(
            "The short article on Csaba",
            By.Id("csaba"));
    //-----------------------------//
    }

}
