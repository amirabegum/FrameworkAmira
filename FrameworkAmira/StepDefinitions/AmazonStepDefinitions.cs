using FrameworkAmira.Applications;
using FrameworkAmira.Drivers;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FrameworkAmira.StepDefinitions
{
    [Binding]
    public class AmazonStepDefinitions
    {
        public Amazon _amazon;
        public Driver _driver;

        public AmazonStepDefinitions(Amazon amazon, Driver driver)
        {
            _amazon = amazon;
            _driver = driver;
        }

        [StepDefinition(@"I am logged into my account")]
        public void GivenIAmLoggedIntoMyAccount()
        {
            _amazon.HomePage.SignInTab.Click(); 
            _amazon.HomePage.EmailInputBox.SendKeys("amira.begum@roq.co.uk"); 
            _amazon.HomePage.ContinueButton.Click();
            _amazon.HomePage.PasswordInputBox.SendKeys("Amira123"); 
            _amazon.HomePage.SignInButton.Click(); 
            
        }

        [StepDefinition(@"I search for ""([^""]*)"" in the search bar")]
        public void WhenISearchForInTheSearchBar(string books)
        {
            _amazon.HomePage.SearchBar.SendKeys(books);
            _amazon.HomePage.SearchButton.Click();
        }

        [StepDefinition(@"the books results will be displayed")]
        public void ThenTheBooksResultsWillBeDisplayed()
        {
            _amazon.HomePage.BooksHeading.Displayed.Should().BeTrue();
        }

        [StepDefinition(@"I select ""([^""]*)"" from the main menu")]
        public void WhenISelectFromTheMainMenu(string option)
        {
            _amazon.HomePage.MenuTab(option).Click();
        }

        [StepDefinition(@"I am on the Amazon Homepage")]
        public void GivenIAmOnTheAmazonHomepage()
        {
            Assert.That(_amazon.HomePage.pageTitle, Does.Match("Amazon.co.uk: Low Prices in Electronics, Books, Sports Equipment & more").IgnoreCase);
            _amazon.HomePage.AcceptCookiesButton.Click();
        }

        [StepDefinition(@"the search filter is set to ""([^""]*)""")]
        public void WhenTheSearchFilterIsSetTo(string option)
        {
           _amazon.HomePage.filterDropdown.Click();
            _amazon.HomePage.filter(option).Click();
            
        }

        [StepDefinition(@"I submit the search bar")]
        public void WhenISubmitTheSearchBar()
        {
            _amazon.HomePage.SearchButton.Click();
        }

        [StepDefinition(@"""([^""]*)"" will be present in the Department filters")]
        public void ThenWillBePresentInTheDepartmentFilters(string department)
        {
            _amazon.HomePage.departmentFilter(department).Displayed.Should().BeTrue();
        }

    }
}
