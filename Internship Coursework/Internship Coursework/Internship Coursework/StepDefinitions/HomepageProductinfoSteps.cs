using System;
using System.Threading;
using Internship_Coursework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Internship_Coursework.StepDefinitions
{
    [Binding]
    public class HomepageProductinfoSteps
    {
        [Given(@"I navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            Hooks1.driver.Navigate().GoToUrl("http://www.qa1.giftrt.com");
            Hooks1.driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            Hooks1.driver.FindElement(By.XPath("//span[text()='Login']")).Click();
        }
        
        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            Hooks1.driver.FindElement(By.XPath("//input[@id='user_email']")).SendKeys("honeydebbie2002@yahoo.co.uk");
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            Hooks1.driver.FindElement(By.XPath("//input[@name='user_password']")).SendKeys("Internship1");
        }
        
        [When(@"I click sign in")]
        public void WhenIClickSignIn()
        {
            Hooks1.driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();
        }
        
        [When(@"I click the hometab")]
        public void WhenIClickTheHometab()
        {
            Thread.Sleep(5000);
            Hooks1.driver.FindElement(By.XPath("//a[@class='brdcum']")).Click();
        }
        
        [When(@"I click free items")]
        public void WhenIClickFreeItems()
        {
            Hooks1.driver.FindElement(By.XPath("//h3[text()='Giftrete-cycle']")).Click();
        }
        
        [When(@"I click wishlist")]
        public void WhenIClickWishlist()
        {
            Hooks1.driver.FindElement(By.XPath("//h3[text()='Wishlist']")).Click();
        }
        
        [When(@"I click community")]
        public void WhenIClickCommunity()
        {
            Hooks1.driver.FindElement(By.XPath("//h3[text()='Community']")).Click();
        }
        
        [Then(@"I have the information about the products")]
        public void ThenIHaveTheInformationAboutTheProducts()
        {
            
            Assert.IsTrue(Hooks1.driver.FindElement(By.XPath("//p[text()='What is Giftreterecycle']")).Displayed);
            Thread.Sleep(5000);
            Assert.IsTrue(Hooks1.driver.FindElement(By.XPath("//p[text()='Creating Wishlist']")).Displayed);
            Assert.IsTrue(Hooks1.driver.FindElement(By.XPath("//p[text()='Joining Community']")).Displayed);
                
                }
    }
}
