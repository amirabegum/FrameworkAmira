using FrameworkAmira.Applications.SwagLabs;
using FrameworkAmira.Drivers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAmira.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        public SwagLabs _swagLabs;
        public Driver _driver;

        public LoginStepDefinitions(SwagLabs swagLabs, Driver driver)
        {
            _swagLabs = swagLabs;
            _driver = driver;
        }

        [StepDefinition(@"I am on the SwagLabs Page")]
        public void GivenIAmOnTheSwagLabsPage()
        {
            _swagLabs.Login.SwagLabsLogo.Displayed.Should().BeTrue();
        }

        [StepDefinition(@"I enter the username ""([^""]*)""")]
        public void WhenIEnterTheUsername(string username)
        {
            _swagLabs.Login.Username.SendKeys(username);
        }

        [StepDefinition(@"I enter the password")]
        public void WhenIEnterThePassword()
        {
            _swagLabs.Login.Password.SendKeys("secret_sauce");
        }

        [StepDefinition(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            _swagLabs.Login.LoginButton.Click();
        }

        [StepDefinition(@"I am logged into SwagLabs")]
        public void GivenIAmLoggedIntoSwagLabs()
        {
            GivenIAmOnTheSwagLabsPage();
            WhenIEnterTheUsername("standard_user");
            WhenIEnterThePassword();
            WhenIClickTheLoginButton();
            _swagLabs.Products.ProductTitle.Displayed.Should().BeTrue();

        }

        [StepDefinition(@"the user cannot login")]
        public void ThenTheUserCannotLogin()
        {
            _swagLabs.Login.LoginErrorMessage.Displayed.Should().BeTrue();
        }

    }
}
