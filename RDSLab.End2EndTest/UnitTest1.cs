using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace RDSLab.End2EndTest
{
    public class Tests
    {
        ChromeDriver chromeDriver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            chromeDriver.Url = "https://www.valueresearchonline.com/";
            chromeDriver.Navigate();
            IWebElement searchIcon = chromeDriver.FindElement(By.XPath("/html/body/nav/div/div/ul/li[9]/a"));
            searchIcon.Click();
            Thread.Sleep(5000);
            IWebElement searchBox = chromeDriver.FindElement(By.Id("input-search"));
            searchBox.SendKeys("N");
            Thread.Sleep(5000);
            searchBox.SendKeys("T");
            Thread.Sleep(5000);
            searchBox.SendKeys("P");
            Thread.Sleep(5000);
            searchBox.SendKeys("C");
            Thread.Sleep(5000);
            searchBox.Click();
            //IWebElement result = chromeDriver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div/span/form/div/span/div/div[2]/div[1]/div"));
            //result.Click();
            Assert.Pass();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {

        }

        [OneTimeTearDown]
        public void OnTimeTearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Close();
        }
    }
}