﻿using FrameworkAmira.Drivers;
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
        public IWebElement BooksHeading => _driver.driver.FindElement(By.XPath("//h1[text()='Books']"));
        public IWebElement filterDropdown => _driver.driver.FindElement(By.Id("nav-search-dropdown-card"));
        public IWebElement MenuTab(string option) => _driver.driver.FindElement(By.XPath($"//div[@id='nav-xshop-container']//a[text()='{option}']"));
        public IWebElement filter(string option) => _driver.driver.FindElement(By.XPath($"//select[@id='searchDropdownBox']//option[text()='{option}']"));
        public IWebElement departmentFilter(String department) => _driver.driver.FindElement(By.XPath($"//div[@id='departments']//span[text()='{department}']"));
        public IWebElement userName => _driver.driver.FindElement(By.XPath("//span[contains(text(),'Amira')]"));
        public IWebElement gardenFurniture => _driver.driver.FindElement(By.Id("gardenfurniture"));




        public string pageTitle()
        {
            return _driver.driver.Title;
        }
    }
}
