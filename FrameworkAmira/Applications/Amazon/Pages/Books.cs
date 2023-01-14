using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkAmira.Drivers;
using OpenQA.Selenium;

namespace FrameworkAmira.Applications.Pages
{
    public class Books
    {
        public Driver _driver; //declaring the Driver 
        public Books(Driver driver) { _driver = driver; } //constructor

        public IWebElement authorFilter(string author) => _driver.driver.FindElement(By.XPath($"//ul[@class='a-unordered-list a-nostyle a-vertical a-spacing-medium']//span[contains(text(),'{author}')]"));
        public IWebElement searchResultNumber => _driver.driver.FindElement(By.XPath("//div[@class='sg-col-inner']//span[contains(text(),'results')]"));
    }
}
