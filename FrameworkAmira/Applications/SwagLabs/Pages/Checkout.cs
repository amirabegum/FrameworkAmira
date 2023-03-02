using FrameworkAmira.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAmira.Applications.SwagLabs.Pages
{
    public class Checkout
    {
        public Driver _driver; //declaring the Driver 
        public Checkout(Driver driver) { _driver = driver; } //constructor

        public IWebElement CheckoutBackpack => _driver.driver.FindElement(By.XPath("//div[@class='cart_item']//div[text()='Sauce Labs Backpack']"));
        public IWebElement RemoveBackpack => _driver.driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement RemovedItem => _driver.driver.FindElement(By.ClassName("removed_cart_item"));
        public IWebElement CheckoutButton => _driver.driver.FindElement(By.Id("checkout"));
        public IWebElement FirstName => _driver.driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => _driver.driver.FindElement(By.Id("last-name"));
        public IWebElement PostCode => _driver.driver.FindElement(By.Id("postal-code"));
        public IWebElement Continue => _driver.driver.FindElement(By.Id("continue"));
        public IWebElement Finish => _driver.driver.FindElement(By.Id("finish"));
        public IWebElement CompleteOrderHeader => _driver.driver.FindElement(By.ClassName("complete-header"));

    }
}
