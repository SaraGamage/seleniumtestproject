using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTestProject
{
    public static class TestCases
    {

        public static void CanRunTestHittingWebsiteOfMyChoosing(IWebDriver driver)
        {

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

        
        
    }


    
}

