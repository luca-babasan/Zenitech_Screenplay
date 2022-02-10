using OpenQA.Selenium;
using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;
using OpenQA.Selenium.Support;
using ImTools;
using System.Collections.Generic;
using System;

namespace ScreenPlayPOC.Locators
{
    public class ZenitechPage
    {
        public const string baseUrl = "https://zenitech.co.uk/";

        //We use "IWebLocator" to define an elements's locator by : ClassName, CssSelector, Id, LinkText, Name, PartialLinkText, TagName, XPath
        
        //Locators for "Find available QA jobs in Cluj-Napoca" scenario
        public static IWebLocator CareersTab => L(
            "Join Us Tab of the website", //this is the description for the element
            By.LinkText("Careers")); //this is the driver.FindElement.By.Xpath() part.
        public static IWebLocator SearchJobs => L(
            "Search Jobs Tab of the website",
            By.LinkText("Search jobs"));
        public static IWebLocator SearchLocations => L(
            "Select job location",
            By.Id("search-box"));
        public static IWebLocator QAJobs => L(
            "Available QA Jobs",
            By.Id("results"));
        public static IWebLocator FirstJob => L(
            "Available jobs in Cluj Napoca",
            By.CssSelector("#results > div:nth-child(1)"));
        public static IWebLocator SecondJob => L(
            "Available jobs in Cluj Napoca",
            By.CssSelector("#results > div:nth-child(2)"));
        /*
        public List<string> GetQAjobs()
        {
            IList<IWebElement> elementList = (IList<IWebElement>)QAJobs;
            List<string> validations = new List<string>();
            foreach (IWebElement element in elementList)
            {
                validations.Add(element.ToString());
            }
            Console.WriteLine(validations);
            return validations;
        }
        */
    //-----------------------------//
    //Locators for "Contact" scenario
        public static IWebLocator ContactTab => L("Contact Tab", By.LinkText("Contact"));
        public static IWebLocator Country_field => L("Country filed of form", By.Name("Country"));
        public static IWebLocator Phone_field => L("Phone field of form", By.Name("Phone"));
        public static IWebLocator First_name_field => L("First name field of form", By.Name("First Name"));
        public static IWebLocator Last_name_field => L("Last name filed of form", By.Name("Last Name"));
        public static IWebLocator email_field => L("Email field of form", By.Name("Email"));
        public static IWebLocator Message_field => L("Message field of form", By.Name("Description"));
        public static IWebLocator Send_button => L("Send form button", By.Id("formsubmit"));
    //-----------------------------//   
    //Locators for "Find Csaba" scenario

        public static IWebLocator About_section => L(
            "About section",
            By.LinkText("About")); 
        public static IWebLocator Csaba_button => L(
            "People Tab",
            By.LinkText("Csaba Suket"));
        public const string People_section_link = "https://zenitech.co.uk/people/#csaba";
        
        public static IWebLocator Csaba_article => L(
            "The short article on Csaba",
            By.Id("csaba"));
    //-----------------------------//
    }

}
