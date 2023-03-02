using FrameworkAmira.Applications.SwagLabs;
using FrameworkAmira.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAmira.StepDefinitions
{
    [Binding]
    public class CheckoutStepDefinitions
    {
        public SwagLabs _swagLabs;
        public Driver _driver;

        public CheckoutStepDefinitions(SwagLabs swagLabs, Driver driver)
        {
            _swagLabs = swagLabs;
            _driver = driver;
        }

        [StepDefinition(@"the backpack is added to the cart")]
        public void ThenTheBackpackIsAddedToTheCart()
        {
            _swagLabs.Checkout.CheckoutBackpack.Displayed.Should().BeTrue();
        }

        [StepDefinition(@"I click on the Remove button")]
        public void WhenIClickOnTheRemoveButton()
        {
            _swagLabs.Checkout.RemoveBackpack.Click();
        }

        [StepDefinition(@"the backpack will be removed from the cart")]
        public void ThenTheBackpackWillBeRemovedFromTheCart()
        {
            _swagLabs.Checkout.RemovedItem.Displayed.Should().BeFalse();
        }

        [StepDefinition(@"I click on Checkout")]
        public void WhenIClickOnCheckout()
        {
            _swagLabs.Checkout.CheckoutButton.Click();
        }

        [StepDefinition(@"I enter the first name ""([^""]*)""")]
        public void WhenIEnterTheFirstName(string fname)
        {
            _swagLabs.Checkout.FirstName.SendKeys(fname);
        }

        [StepDefinition(@"I enter the last name ""([^""]*)""")]
        public void WhenIEnterTheLastName(string lname)
        {
            _swagLabs.Checkout.LastName.SendKeys(lname);
        }

        [StepDefinition(@"I enter the post code ""([^""]*)""")]
        public void WhenIEnterThePostCode(string postcode)
        {
           _swagLabs.Checkout.PostCode.SendKeys(postcode);
        }

        [StepDefinition(@"I click Continue")]
        public void WhenIClickContinue()
        {
           _swagLabs.Checkout.Continue.Click();
        }

        [StepDefinition(@"I click Finish")]
        public void WhenIClickFinish()
        {
            _swagLabs.Checkout.Finish.Click();
        }

        [StepDefinition(@"the order has been successfully completed")]
        public void ThenTheOrderHasBeenSuccessfullyCompleted()
        {
            _swagLabs.Checkout.CompleteOrderHeader.Displayed.Should().BeTrue();
        }


    }
}
