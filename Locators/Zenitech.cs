using OpenQA.Selenium;
using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace ScreenPlayPOC.Locators
{
    public class ZenitechPage
    {
        public const string baseUrl = "https://zenitech.co.uk/";

        //We use "IWebLocator" to define an elements's path by : ClassName, CssSelector, Id, LinkText, Name, PartialLinkText, TagName, XPath
        public static IWebLocator WhoWeAre_section => L(
            "Who we are", //this is the description for the element
            By.LinkText("Who We Are")); //this is the driver.FindElement.By() part.
        public static IWebLocator whatWeDo_tab => L(
            "What We Do Tab",
            By.LinkText("What We Do"));

        //To make sure we're seeing the article, we'll validate that it's on-screen first
        public static IWebLocator KingaArticle => L(
            "The whole article about Kinga",
            By.ClassName("what-we-do-articles-module--article--3WMSW"));
        public const string newsUrlforKingaValidation = "https://zenitech.co.uk/what-we-do/articles/hungary-office-launch/";
        //we'll define a static string as a simple example of content validation, but we could also get values from an API or a database
        public const string kingaQuote = "Supporting our growth as individuals is hugely important to me, as well as growing the business, because when we thrive, everyone benefits. I’m thrilled to join Zenitech at this exciting time in our development and I can’t wait to welcome our new colleagues as we begin to grow our team in Hungary";

        public static IWebLocator articleContent => L(
           "The content of the article",
           By.XPath("/html/body/div/div[1]/main/section[1]/article"));
//------------------------------//
        //Locators for "Find available jobs in Cluj-Napoca" scenario
        public static IWebLocator JoinUsTab => L(
            "Join Us Tab of the website",
            By.LinkText("Join Us"));
        public static IWebLocator Cluj_NapocaJobs => L(
            "Available jobs in Cluj Napoca",
            By.XPath("/html/body/div/div[1]/main/div[2]/section[2]/ul"));
        //-----------------------------//
        //Locators for "Apply for Job" scenario
        public static IWebLocator sendCVbutton => L("Send your CV button", By.ClassName("btn"));
        public static IWebLocator I_am_interested_in_field => L("I am interested in* field", By.Name("position"));
        public static IWebLocator location_dropdown => L("Location filed of form", By.XPath("/html/body/div[1]/div[1]/main/div/div[2]/form/div[4]"));
        public static IWebLocator location_Cluj_Napoca => L("Select location -> Cluj-Napoca", By.XPath("/html/body/div[1]/div[1]/main/div/div[2]/form/div[4]/div[2]/ul/li[2]"));
        public static IWebLocator full_name_field => L("Full name field of form", By.Name("name"));
        public static IWebLocator email_field => L("Email field of form", By.Name("email"));
        public static IWebLocator phone_number_field => L("Phone number filed of form", By.Name("phone"));
        public static IWebLocator linkedIn_profile_field => L("LinkedIn profile filed of form", By.Name("linkedin"));
        public static IWebLocator github_repo_field => L("Github profile field of form", By.Name("github"));
        public static IWebLocator other_details_field => L("Other details field of form", By.Name("other"));
        public static IWebLocator Apply_now => L("Apply Now button", By.ClassName("mdc-button__label"));
        public const string CV = "https://zenitech.co.uk/join-the-community/we-offer/suggest/";

        

    }

}
