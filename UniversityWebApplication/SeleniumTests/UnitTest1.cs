using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace SeleniumTests
{
    public class UnitTest1
    {
        [Fact]
        public void LoadLocalhost()
        {
            using IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.google.com"); //užkrauna
            driver.Navigate().GoToUrl("https://localhost:44310/Home/Index/"); //neužkrauna
        }
    }
}
