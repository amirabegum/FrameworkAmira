using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using FrameworkAmira.Applications;
using FrameworkAmira.Drivers;
using OpenQA.Selenium;
namespace FrameworkAmira.StepDefinitions.Hooks
{
    [Binding]
    public class Runner
    {
        //external container that stores things 
        //used to pass elements or driver 
        IObjectContainer _objectContainer;
        ScenarioContext _scenarioContext;
        Driver _driver;
        static ExtentReports extent;
        static ExtentTest feature;
        static ExtentTest scenario;
        static string reportPath = Path.Join(Directory.GetParent(@"../../../").FullName, "Result", "Result_" + DateTime.Now.ToString("ddMMyyyy HHmmss")) + Path.DirectorySeparatorChar;
        public Runner(IObjectContainer objectContainer, Driver driver, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _driver = driver;
            _scenarioContext = scenarioContext;
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Directory.CreateDirectory(reportPath);
            extent = new ExtentReports();
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reportPath);
            extent.AttachReporter(htmlreport);
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest<Feature>(context.FeatureInfo.Title);
        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            scenario = feature.CreateNode<Scenario>(context.ScenarioInfo.Title);
            _driver.BrowserTypeSwitch("Edge", true);
            _driver.Init("https://www.amazon.co.uk/");
            // _objectContainer.RegisterInstanceAs<Driver>(_driver); //can call from object container, can run multiple simultaneously
            _objectContainer.RegisterInstanceAs<Amazon>(new Amazon(_driver));
        }
        [BeforeStep]
        public void BeforeStep()
        {
        }
        [AfterStep]
        public void AfterStep()
        {
            if (_scenarioContext.TestError == null)
            {
                scenario.Log(Status.Pass, _scenarioContext.StepContext.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {
                var type = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();  //what is the type of step, looks at step and what is the info in scenario 
                string stepName = _scenarioContext.StepContext.StepInfo.Text;
                string screenshot = ((ITakesScreenshot)_driver.driver).GetScreenshot().AsBase64EncodedString;
                ExtentTest step;
                if (type.Equals("Given"))
                {
                    scenario.CreateNode<Given>(stepName).AddScreenCaptureFromBase64String(screenshot).Fail(_scenarioContext.TestError.Message);
                    //InnerException
                }
                else if (type.Equals("When"))
                {
                    scenario.CreateNode<When>(stepName).AddScreenCaptureFromBase64String(screenshot).Fail(_scenarioContext.TestError.Message);
                }
                else if (type.Equals("Then"))
                {
                    scenario.CreateNode<Then>(stepName).AddScreenCaptureFromBase64String(screenshot).Fail(_scenarioContext.TestError.Message);
                }
                else if (type.Equals("And"))
                {
                    scenario.CreateNode<And>(stepName).AddScreenCaptureFromBase64String(screenshot).Fail(_scenarioContext.TestError.Message);
                }
                scenario.Log(Status.Fail, _scenarioContext.StepContext.StepInfo.Text);
            }
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            _driver.driver.Quit();
        }
    }
}