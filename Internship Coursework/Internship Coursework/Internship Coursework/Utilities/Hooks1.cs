using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Internship_Coursework.Utilities
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(); 
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit(); 
        }
    }
}
