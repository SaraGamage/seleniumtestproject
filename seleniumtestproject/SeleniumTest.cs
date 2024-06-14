using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown() => driver?.Quit();

        public string waitForWindow(int timeout)
        {
            try
            {
                Thread.Sleep(timeout);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            var whNow = ((IReadOnlyCollection<object>)driver.WindowHandles).ToList();
            var whThen = ((IReadOnlyCollection<object>)vars["WindowHandles"]).ToList();
            if (whNow.Count > whThen.Count)
            {
                return whNow.Except(whThen).FirstOrDefault().ToString();
            }
            else
            {
                return whNow.First().ToString();
            }
        }

        [Test]
        public void Test01()
        {
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2000);
            TestCases.CanRunTestHittingWebsiteOfMyChoosing(driver);
            Assert.Pass();
        }

        [Test]
        public void Test02()
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
            var url = driver.FindElement(By.ClassName("byrV5b"));
            
            url.Click();

            //webElement.Click();

        }

    }
}
