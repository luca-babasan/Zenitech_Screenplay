using OpenQA.Selenium;
using Boa.Constrictor.WebDriver;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace ScreenPlayPOC.Locators
{
    public class ValuesList
    {
        //We can have a list of predefined values to use so our testcases are more readable and make more sense
        public static string Country = "Romania";
        public static string Phone = "0748533618";
        public static string First_name = "Luca";
        public static string Last_name = "Babasan";
        public static string Email_field = "luca.babasan@zenitech.co.uk";
        public static string Message = "Selenium is doing it's thing and adding text to this message field";
    }
}
