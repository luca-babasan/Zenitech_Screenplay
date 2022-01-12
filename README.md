# Zenitech_Screenplay
Automated testing example on the Zenitech website,
Using Specflow .NET and screenplay design patten impementation in C# (Boa-Constrictor)

--OS Requirements: Windows 10 and above or macOS High Sierra 10.13 and above

--Code Editor: Visual Studio 2019 community edition (free)

--Extensions: SpecFlow for Visual Studio 2019 (or latest)

--NuGet Packages: SpecFlow.Actions.BoaConstrictor or Boa.Constrictor (Original lib)

Selenium.WebDriver (and optionally Selenium.Support)

*For macOS you will need the additional pack: Selenium.WebDriver.ChromeDriver
User Secrets (for credentials management - optional)

--To run a test via command line:
cd into your project folder and them just run:
dotnet test (to run all test in your project folder)


dotnet test --filter Category=done

dotnet test --filter "Category=us123 & Category=done"

dotnet test --filter "Category=us123 | Category=done"
(here Category refers to the @mytag from the .feature files where we wrote our scenarios in Gherkin
