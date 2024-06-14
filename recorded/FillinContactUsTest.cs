// Generated by Selenium IDE
//
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class FillinContactUsTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  public string waitForWindow(int timeout) {
    try {
      Thread.Sleep(timeout);
    } catch(Exception e) {
      Console.WriteLine("{0} Exception caught.", e);
    }
    var whNow = ((IReadOnlyCollection<object>)driver.WindowHandles).ToList();
    var whThen = ((IReadOnlyCollection<object>)vars["WindowHandles"]).ToList();
    if (whNow.Count > whThen.Count) {
      return whNow.Except(whThen).First().ToString();
    } else {
      return whNow.First().ToString();
    }
  }
  [Test]
  public void fillinContactUs() {
    driver.Navigate().GoToUrl("https://c-datalab.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1040);
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector(".button:nth-child(2) font > font")).Click();
    vars["win2234"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win2234"].ToString());
    driver.FindElement(By.Id("company-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).Click();
    driver.FindElement(By.Id("company-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).SendKeys("company name");
    driver.FindElement(By.Id("lastname-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).Click();
    driver.FindElement(By.Id("lastname-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).SendKeys("surname");
    driver.FindElement(By.Id("firstname-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).Click();
    driver.FindElement(By.Id("firstname-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).SendKeys("given");
    driver.FindElement(By.Id("email-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).Click();
    driver.FindElement(By.Id("email-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).SendKeys("test@sample.com");
    driver.FindElement(By.Id("email-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).Click();
    {
      var element = driver.FindElement(By.Id("email-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.Id("email-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.Id("email-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.Id("email-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).Click();
    driver.FindElement(By.Id("email-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).SendKeys("test@microsoft.com");
    driver.FindElement(By.Id("message-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).Click();
    driver.FindElement(By.Id("LEGAL_CONSENT.subscription_type_217707079-a91254e9-2e5e-4f4b-adfa-0fa0107f988a_593")).Click();
    //driver.FindElement(By.CssSelector(".hs-button")).Click();
    js.ExecuteScript("window.scrollTo(0,461)");
  }
}