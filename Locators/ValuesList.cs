using OpenQA.Selenium;
using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace ScreenPlayPOC.Locators
{
    public class ValuesList
    {
        //We can have a list of predefined values to use so our testcases are more readable and make more sense
        public static string I_am_interested_in_info = "The latest automation technologies";
        public static string full_name_info = "Luca Babasan";
        public static string email_field_info = "luca.babasan@zenitech.co.uk";
        public static string phone_number_info = "0748533618";
        public static string linkedIn_profile_info = "https://www.linkedin.com/in/babasan-luca-emanuel";
        public static string github_repo_info = "https://github.com/q2ebanking/boa-constrictor";
        public static string ther_details_field = "Can be persuaded with coffee and cookies";
    }
}
