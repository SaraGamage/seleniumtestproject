
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace SeleniumTestProject
{
    [TestFixture]
    [Category("ExcludeFailures")]
    public class SeleniumTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor? js;
        private bool isProduction = false;
        
         [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            TestManagement.CheckEnvironment(isProduction);
        }

        [SetUp]
        public void SetUp()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--verbose");
            //chromeOptions.AddArguments("--output-directory=results");
            //new diver created
            driver = new ChromeDriver(chromeOptions);
            //driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
      
        [Test, Description("Submit google search")]
        public void GoogleSearch()
        {
            TestManagement.TestHittingGoogleSearch(driver);

        }

        [Test, Description("Can load page of my choice")]
        public void TestHittingSomeWebsite()
        {
            TestManagement.TestHittingSomeWebsite(driver);
        }

        [Test, Description("Always passes")]
        public void Test03()
        {
            Assert.That(true);
        }

        [Test, Description("Always passes")]
        public void Test04()
        {
            Assert.That(true);
        }

        [Test, Description("Always passes")]
        public void Test05()
        {
            Assert.That(true);
        }

        [Test, Description("A very specific test that needs to do 1 thing in dev, another in prod")]
        public void TwoSecondTestOnDevHalfSecondOnProd()
        {
            if (isProduction)
            {
                Console.WriteLine($"If Prod then we're going to not sleep as long");
                Thread.Sleep(500);
            }
            else
            {
                Thread.Sleep(2000);
            }
            Assert.That(true);
        }

        [Test, Description("Always passes")]
        public void Test07()
        {
            Assert.That(true);
        }

        [Test, Description("Always passes")]
        public void Test08()
        {
            Assert.That(true);
        }

        [Test, Description("Always fail")]
        public void Test09()
        {
            Assert.That(true);
        }

    }

    [Category("IncludeFailures")]
    [TestFixture]
    public class FailingTests
    {

        [Test]
        public void FailureOne()
        {
            Assert.That(false);
       }

        [Test]
        public void FailureTwo()
        {
            Assert.That(false);
       }

        [Test]
        public void GoodOne()
        {
            Assert.That(true);
        }
    }
}