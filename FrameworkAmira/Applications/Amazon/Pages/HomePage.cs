using FrameworkAmira.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAmira.Applications.Pages
{
    public class HomePage 
    {
        public Driver _driver; //declaring the Driver 
        public HomePage(Driver driver) { _driver = driver; } //constructor

        public IWebElement AcceptCookiesButton => _driver.driver.FindElement(By.Id("sp-cc-accept"));
        public IWebElement SignInTab => _driver.driver.FindElement(By.Id("nav-link-accountList"));
        public IWebElement EmailInputBox => _driver.driver.FindElement(By.Id("ap_email"));
        public IWebElement ContinueButton => _driver.driver.FindElement(By.Id("continue"));
        public IWebElement PasswordInputBox => _driver.driver.FindElement(By.Id("ap_password"));
        public IWebElement SignInButton => _driver.driver.FindElement(By.Id("signInSubmit"));
        public IWebElement NotNowButton => _driver.driver.FindElement(By.Id("ap-account-fixup-phone-skip-link"));
        public IWebElement HelloNameLabel => _driver.driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
        public IWebElement SearchBar => _driver.driver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement SearchButton => _driver.driver.FindElement(By.Id("nav-search-submit-button"));
        public IWebElement BooksHeading => _driver.driver.FindElement(By.XPath("//div[@class='bxc-grid__text a-text-left   bxc-grid__text--light']//h11"));
    }
}
