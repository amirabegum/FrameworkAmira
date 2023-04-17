using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace FrameworkAmira.Drivers
{
    public class Driver
    {
        public IWebDriver driver { get; set; }

        public void BrowserTypeSwitch(string BrowserType, bool RemoteExecution)
        {
            if(RemoteExecution == true) { 
            if (BrowserType.Equals("Chrome"))
                {
                   // new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    driver = new RemoteWebDriver(options);
                    // _driver.driver = new ChromeDriver();
                

                }
                else if (BrowserType.Equals("Edge"))
                 {
                
                    //    _driver.driver = new RemoteWebDriver();
                    EdgeOptions options = new EdgeOptions();
                    driver = new RemoteWebDriver(options);
                

                 }
                  else if (BrowserType.Equals("Firefox"))
            {

                    // _driver.driver = new RemoteWebDriver();
                 
                    FirefoxOptions options = new();
                    driver = new RemoteWebDriver(options);
                
            }
            }
            else {
                if (BrowserType.Equals("Chrome"))
                {
                  //  new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("incognito");
                    options.AddArgument("--start-maximized");
                    driver = new ChromeDriver(options);
                   

                }
                else if (BrowserType.Equals("Edge"))
                {

                  
                    driver = new EdgeDriver();


                }
                else if (BrowserType.Equals("Firefox"))
                {

                   
                    driver = new FirefoxDriver();

                }

            }

        }

        public void Init(string url)
        {

            
            driver.Navigate().GoToUrl(url);
        }

        //multi browser 
        //initialise browser method 
        //takes string of browser method 
        //if statements 
        //edge, chrome, firefox

        //call this method elsewhere with string arg

        //Add another parameter thats called remote execution 


    }
}
