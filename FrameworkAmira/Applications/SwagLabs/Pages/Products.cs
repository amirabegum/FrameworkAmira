using FrameworkAmira.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAmira.Applications.SwagLabs.Pages
{
    public class Products
    {
        public Driver _driver; //declaring the Driver 
        public Products(Driver driver) { _driver = driver; } //constructor

        public IWebElement ProductTitle => _driver.driver.FindElement(By.ClassName("title"));
        public IWebElement BackPackAddToCart => _driver.driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement TShirtAddToCart => _driver.driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement BikeLightAddToCart => _driver.driver.FindElement(By.Id(""));
        public IWebElement CartButton => _driver.driver.FindElement(By.ClassName("shopping_cart_link"));
        public IWebElement Filter => _driver.driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement LowToHighFilter => _driver.driver.FindElement(By.XPath("//option[text()='Price (low to high)']"));
        public IWebElement CheapestItem => _driver.driver.FindElement(By.Id("item_2_img_link"));
    }

   
}
