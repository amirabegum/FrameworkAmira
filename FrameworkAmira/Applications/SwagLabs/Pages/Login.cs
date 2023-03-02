using FrameworkAmira.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAmira.Applications.SwagLabs.Pages
{
    public class Login
    {
        public Driver _driver; //declaring the Driver 
        public Login(Driver driver) { _driver = driver; } //constructor

        public IWebElement SwagLabsLogo => _driver.driver.FindElement(By.ClassName("login_logo"));
        public IWebElement Username => _driver.driver.FindElement(By.Id("user-name"));
        public IWebElement Password => _driver.driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => _driver.driver.FindElement(By.Id("login-button"));
        public IWebElement LoginErrorMessage => _driver.driver.FindElement(By.XPath("//h3[@data-test='error']"));

    }
}
