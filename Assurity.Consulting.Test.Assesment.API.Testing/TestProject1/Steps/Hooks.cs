using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;

using TechTalk.SpecFlow;

namespace AssurityConsultingTestAssessment.Steps
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;

        [BeforeTestRun]
        public static void BeforeTesRun()
        {
            var path = GetTestReportPath();
            _extentHtmlReporter = new ExtentHtmlReporter(path);
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
            
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if(null != featureContext)
            {
               _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title, featureContext.FeatureInfo.Description);                
            }
        }
        
        [BeforeScenario()]
        public void BeforeScenarioWithTag(ScenarioContext scenarioContext)
        {

            if (null != scenarioContext)
            {
                _scenarioContext = scenarioContext;
                _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title, scenarioContext.ScenarioInfo.Description);
            }           
        }

        [AfterStep]
        public void AfterEachStep(ScenarioContext scenarioContext)
        {

            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;
            switch(scenarioBlock)
            {
                case ScenarioBlock.Given:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<Given>(_scenarioContext.TestError.Message).Fail("\n" + _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    }                   
                    break;
                case ScenarioBlock.When:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<When>(_scenarioContext.TestError.Message).Fail("\n" + _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    }                    
                    break;                     
                case ScenarioBlock.Then:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<Then>(_scenarioContext.TestError.Message).Fail("\n" + _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    }
                    break; 
                default:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<And>(_scenarioContext.TestError.Message).Fail("\n" + _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                    }
                    break;
            }

         }

        [AfterTestRun]
        public static void AfterRun()
        {
            _extentReports.Flush();
        } 

        private static string GetTestReportPath()
        {
            var assemblyPath = AppContext.BaseDirectory;
            var actualPath = assemblyPath.Substring(0, assemblyPath.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            return projectPath + @"Report/";
        }
    }
}