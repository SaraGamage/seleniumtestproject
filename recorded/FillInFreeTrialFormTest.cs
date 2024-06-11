// Generated by Selenium IDE
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
public class FillInFreeTrialFormTest {
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
  public void fillInFreeTrialForm() {
    driver.Navigate().GoToUrl("https://c-datalab.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1805, 1224);
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector(".widget_1699916975531__primary_cta font > font")).Click();
    vars["win2299"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win2299"].ToString());
    driver.FindElement(By.CssSelector("#hs_cos_wrapper_widget_1707050079194 img")).Click();
    driver.FindElement(By.CssSelector("#hs_cos_wrapper_widget_1707050079194 img")).Click();
    driver.FindElement(By.CssSelector("#hs_cos_wrapper_widget_1707050079194 img")).Click();
    js.ExecuteScript("window.scrollTo(0,3097)");
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector(".button--outlined font > font")).Click();
    vars["win5748"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win5748"].ToString());
    driver.FindElement(By.Id("company-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("company-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("company name");
    driver.FindElement(By.Id("0-2/busho-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("dep");
    driver.FindElement(By.Id("jobtitle-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("some address");
    driver.FindElement(By.Id("lastname-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("surname");
    driver.FindElement(By.Id("firstname-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("given");
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("testing@test.com");
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("testing@testing.com");
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    {
      var element = driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    {
      var element = driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    {
      var element = driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("test@sample.com");
    driver.FindElement(By.Id("message-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("message-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("message-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("qweqwe");
    driver.FindElement(By.CssSelector(".hs-button")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    {
      var element = driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.Id("email-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).SendKeys("test@microsoft.com");
    driver.FindElement(By.Id("message-3adddb97-436d-42bf-9bfc-d64b70f05403_7546")).Click();
    driver.FindElement(By.CssSelector(".hs-button")).Click();
    driver.FindElement(By.CssSelector(".row-number-1")).Click();
  }
}
