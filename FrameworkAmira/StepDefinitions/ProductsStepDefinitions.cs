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
    public class ProductsStepDefinitions
    {
        public SwagLabs _swagLabs;
        public Driver _driver;

        public ProductsStepDefinitions(SwagLabs swagLabs, Driver driver)
        {
            _swagLabs = swagLabs;
            _driver = driver;
        }

        [StepDefinition(@"I have successfully logged in")]
        public void ThenIHaveSuccessfullyLoggedIn()
        {
            _swagLabs.Products.ProductTitle.Displayed.Should().BeTrue();
        }

        [StepDefinition(@"I click on the Cart button")]
        public void WhenIClickOnTheCartButton()
        {
            _swagLabs.Products.CartButton.Click();
        }

        [StepDefinition(@"I click the Add To Cart button for a backpack")]
        public void WhenIClickTheAddToCartButtonForABackpack()
        {
            _swagLabs.Products.BackPackAddToCart.Click();
        }

        [StepDefinition(@"I click on the Filter icon")]
        public void WhenIClickOnTheFilterIcon()
        {
            _swagLabs.Products.Filter.Click();
        }

        [StepDefinition(@"I select lowest to highest")]
        public void WhenISelectLowestToHighest()
        {
           _swagLabs.Products.LowToHighFilter.Click();
        }

        [StepDefinition(@"the products have been filtered")]
        public void ThenTheProductsHaveBeenFiltered()
        {
           _swagLabs.Products.CheapestItem.Displayed.Should().BeTrue();
             
        }


    }
}
