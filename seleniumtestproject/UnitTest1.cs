using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //strange approach??
            FirstScript.SeleniumTest1();
            Assert.Pass();
        }

        [Test]
        public void ActualTestWhereIWantToCheckIfICanRunSeliumTestHittingAwEbisteOfMuChoosing()
        {
            IWebDriver driver = GetDriverForOurSite();

            var title = driver.Title;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

            var textBox = driver.FindElement(By.Name("my-text"));
            var submitButton = driver.FindElement(By.TagName("button"));

            textBox.SendKeys("Selenium");
            submitButton.Click();

            var message = driver.FindElement(By.Id("message"));
            var actual = message.Text;

            Assert.That(actual, Is.EqualTo("Received!"));
            driver.Quit();
        }

        [Test]
        public void TestingBevaiourTwo()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://c-datalab.com/");

            var title = driver.Title;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

            var textBox = driver.FindElement(By.Name("my-other-test-field"));
            var submitButton = driver.FindElement(By.TagName("button"));

            textBox.SendKeys("Selenium");
            submitButton.Click();

            var message = driver.FindElement(By.Id("message"));
            var actual = message.Text;

            Assert.That(actual, Is.EqualTo("Spkme other resposense!"));
            driver.Quit();
        }

        private static IWebDriver GetDriverForOurSite()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
            return driver;
        }
    }
}
