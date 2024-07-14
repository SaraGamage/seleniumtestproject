using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTestProject
{
    public static class TestManagement
    {
        public static void SetUpDriver(IWebDriver? driver, ChromeOptions chromeOptions, IJavaScriptExecutor? js)
        {
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--verbose");
            //chromeOptions.AddArguments("--output-directory=results");
            //new diver created
            driver = new ChromeDriver(chromeOptions);
            //driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            
        }

        public static void CheckEnvironment( bool isProduction)
        {
            isProduction = false;
            string testingEnvironment = Environment.GetEnvironmentVariable("TEST_ENV") ?? "Development";
            string testingVersionOrCommit = Environment.GetEnvironmentVariable("TEST_VER") ?? "Unknown";
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"TestingEnvironment {testingEnvironment}");
            Console.WriteLine($"TestingVersionOrCommit {testingVersionOrCommit}");
            Console.WriteLine($"-----------------------------------------------");
           
            isProduction = testingEnvironment.Equals("Production", StringComparison.CurrentCultureIgnoreCase);
           
        }

        public static void TestHittingSomeWebsite(IWebDriver driver)
        {
            //this is a test
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
            var title = driver.Title;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2000);

            var textBox = driver.FindElement(By.Name("my-text"));
            var submitButton = driver.FindElement(By.TagName("button"));

            textBox.SendKeys("Selenium");
            submitButton.Click();

            var message = driver.FindElement(By.Id("message"));
            var actual = message.Text;

            Assert.That(actual, Is.EqualTo("Received!"));

        }

        public static void TestHittingGoogleSearch(IWebDriver driver)
        {
            // 2. Navigate to the URL
            driver.Navigate().GoToUrl("https://www.google.com/");
            // 2a. Maximize the browser window
            driver.Manage().Window.Maximize();
            // 3. Find the element
            IWebElement webElement = driver.FindElement(By.Name("q"));
            // 4. Type in the element
            webElement.SendKeys("Selenium");
            // 5. Click on the element
            webElement.SendKeys(Keys.Return);
            var url = driver.FindElement(By.PartialLinkText("Selenium"));
            if (url != null)
            {
                url.Click();
                Assert.That(true);
            }
            else 
            Assert.That(false);
        }
    }
}